using Avision.Enums;
using Avision.Helpers;
using Avision.Structs;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AvisionTest
{
    internal class Program
    {
        private const string 
            szLicense = "280e1204-0dab-4ecc-8213-47437c53c689", //demo ="396c5502-a763-0091-33a1-1234a8e002b1";
            szProduct = "Test",
            szManufacturer = "Avision",
            defScanerName = "AD8120UN";

        [DllImport("AVSDK_x64.dll")] private static extern int InitializeLib(INITLIBPARAM InitLibParam, ref AVSDKINFO pSDKInfo);
        [DllImport("AVSDK_x64.dll")] private static extern int SelectScanner(ref SELECTSCANNERPARAM SelectScannerParam);
        [DllImport("AVSDK_x64.dll")] private static extern int LoadScanner(string ScannerName, ref SCANNERABILITY pScannerAbility);
        [DllImport("AVSDK_x64.dll")] private static extern int UnloadScanner();
        [DllImport("AVSDK_x64.dll")] private static extern int SetGeneralSetting(GENERALSETTING generalSetting);
        [DllImport("AVSDK_x64.dll")] private static extern int SetAdvancedSetting(ADVANCEDSETTING advancedSetting);
        [DllImport("AVSDK_x64.dll")] private static extern int TerminateLib();
        [DllImport("AVSDK_x64.dll")] private static extern int CommandOperation(byte operation, ushort tag, uint dataType, ushort dataCount, ref byte[] bb);


        static void Main(string[] args)
        {
            try
            {
                initializeLib();
                selectScaner(defScanerName);
                loadScanner(defScanerName);
                loadScannerParams(); // <- error with setting advanced params
                sendCommand(DEFINE_CMDOP_TYPE.CMDOP_READ, AVSDK_OPERATION_TAG.TAG_PAPERLOAD, CMDOP_DATA_TYPE.DT_BYTE, 1);       // <- error with sending commands
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                try { unloadScanner(); } catch { }
                try { terminateLib(); } catch { }
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static AVSDKINFO initializeLib()
        {
            AVSDKINFO sdkInfo = new AVSDKINFO();
            INITLIBPARAM initLibParam = new INITLIBPARAM
            {
                APWnd = Process.GetCurrentProcess().MainWindowHandle,
                szLicense = Marshal.StringToHGlobalAnsi(szLicense),
                szManufacturer = Marshal.StringToHGlobalAnsi(szManufacturer),
                szProduct = Marshal.StringToHGlobalAnsi(szProduct),
                DriverMode = (byte)DEFINE_DRIVER_TYPE.DRIVER_TWAIN,
            };
            int code = InitializeLib(initLibParam, ref sdkInfo);
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception(((AVSDK_ERROR_CODE)code).ToName());
            return sdkInfo;
        }

        private static void terminateLib()
        {
            int code = TerminateLib();
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception(((AVSDK_ERROR_CODE)code).ToName());
        }

        private static void selectScaner(string scannerName = "")
        {
            byte[] scanName = new byte[34];
            byte[] enc = System.Text.Encoding.Default.GetBytes(scannerName);
            if (enc.Length > 34)
                throw new Exception($"Not correct scanner name {enc}");
            for (int i = 0; i < enc.Length; i++)
                scanName[i] = enc[i];
            SELECTSCANNERPARAM SelectScannerParam = new SELECTSCANNERPARAM()
            {
                ShowSelect = false,
                DefaultScanner = scanName,
                DeviceOnline = 0, // all
            };
            int code = SelectScanner(ref SelectScannerParam);
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception(((AVSDK_ERROR_CODE)code).ToName());
            string name = System.Text.Encoding.Default.GetString(SelectScannerParam.DefaultScanner).Trim('\0');
            if (string.IsNullOrEmpty(name))
                throw new Exception("Error with scanner initializing");
            if (name != scannerName)
                throw new Exception("Not correct scanner name");
        }

        private static void loadScanner(string scannerName)
        {
            SCANNERABILITY scannerAbility = new SCANNERABILITY();
            int code = LoadScanner(scannerName, ref scannerAbility);
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception(((AVSDK_ERROR_CODE)code).ToName());
        }

        private static void unloadScanner()
        {
            int code = UnloadScanner();
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception(((AVSDK_ERROR_CODE)code).ToName());
        }

        private static void loadScannerParams()
        {
            GENERALSETTING generalSetting = GENERALSETTING.GetDefaut();
            int code = SetGeneralSetting(generalSetting);
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception($"Error with load global params: {((AVSDK_ERROR_CODE)code).ToName()}");

            //TODO IT DOES NOT WORK CORRECTLY
            ADVANCEDSETTING advancedSettings = ADVANCEDSETTING.GetDefault();
            code = SetAdvancedSetting(advancedSettings);
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception($"Error with load local params: {((AVSDK_ERROR_CODE)code).ToName()}");
        }

        private static void sendCommand(DEFINE_CMDOP_TYPE mode, AVSDK_OPERATION_TAG tag, CMDOP_DATA_TYPE dataType, ushort dataCount)
        {
            //TODO IT DOES NOT WORK CORRECTLY
            byte[] buf = new byte[dataCount];
            for (int i = 0; i < buf.Length; i++)
                buf[i] = 255;
            int code = CommandOperation((byte)mode, (ushort)tag, (uint)dataType, dataCount, ref buf);
            if (code != (int)AVSDK_ERROR_CODE.SDK_SUCCESS)
                throw new Exception($"Error with sending command {tag}: {((AVSDK_ERROR_CODE)code).ToName()}");
        }
    }
}
