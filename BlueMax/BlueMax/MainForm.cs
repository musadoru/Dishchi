using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using BlueMax.Classes;
using System.Runtime.InteropServices;
using BlueMax.DAL;


namespace BlueMax
{
    public partial class MainForm : XtraForm
    {
        /*DbContext db = new DbContext();
        List<SettingsItem> setsList;*/

        public MainForm()
        {
            SplashScreenManager.ShowForm(this, typeof(SplashScreenMain), true, true, false);
            try
            {
                InitializeComponent();
              //  External.sensorConnection = SensorInfo();
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void pbBtnPatient_Click(object sender, EventArgs e)
        {
            using (PatientForm hasta = new PatientForm(null))
            {
                hasta.ShowDialog();
            }
        }

        private void pbBtnImage_Click(object sender, EventArgs e)
        {
            using (ImagesForm goruntu = new ImagesForm())
            {
                goruntu.ShowDialog();
            }
        }

        private void pbBtnSettings_Click(object sender, EventArgs e)
        {
            using (SettingsRvg settings = new SettingsRvg())
            {
                settings.ShowDialog();
            }
        }

        private void pbBtnInfo_Click(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// Sensör bilgilerini al
        /// </summary>
        /// <returns></returns>
     /*   private bool SensorInfo()
        {
            External.TRI_Init_Ori("trident.ini");

            External.sensorNo = External.TRI_GetNumPresent();
            if (External.sensorNo <= 0)
            {
                // sensör bulunamadı
                External.TRI_CleanUp();
                return false;
            }
            else
            {
                // sensör no
                //string _SensorNo = External.sensorNo.ToString();

                External.theHandle = External.TRI_Open(null);

                if (External.theHandle == -1)
                {
                    XtraMessageBox.Show("Bilgiler daha önce alınmış, sensörü bilgisayardan çıkartın ve 15-20 saniye bekledikten sonra tekrar takarak işlemi tekrarlayın.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    // ayarları al
                    GetRvgSettings();

                    External.TRI_Enable(External.theHandle);
                    External.theImageBufSize[0] = External.TRI_GetImageSize(External.theHandle);

                    //***********************************************
                    // seri no
                    IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(External.theCurrentSN, 0);
                    External.TRI_GetSerialNum(External.theHandle, intPtr, 16);
                    string _BTK = Encoding.Default.GetString(External.theCurrentSN).Substring(0, 8);
                    External.btkNS = _BTK;

                    //***********************************************
                    // dijital kazanç
                    IntPtr intPtr1 = Marshal.UnsafeAddrOfPinnedArrayElement(External.DigiGain, 0);
                    External.TRI_GetDigitalGain(External.theHandle, intPtr1);
                    float digiGain = External.DigiGain[0];
                    string _DigiGain = digiGain.ToString();
                    External.digiGain = _DigiGain;

                    //***********************************************
                    // okuma modu
                    IntPtr intPtr3 = Marshal.UnsafeAddrOfPinnedArrayElement(External.theReadOutMode, 0);
                    External.TRI_GetReadOutMode(External.theHandle, intPtr3);
                    string str = External.theReadOutMode[0].ToString();
                    string str1 = str.Substring(12, 1);
                    string str2 = str.Substring(23, 1);
                    string _ReadOut = string.Concat(str1, "_", str2);
                    External.readOut = _ReadOut;

                    //***********************************************
                    // sensör boyutları ve çözünürlük 
                    IntPtr intPtr4 = Marshal.UnsafeAddrOfPinnedArrayElement(External.theNumLines, 0);
                    IntPtr intPtr5 = Marshal.UnsafeAddrOfPinnedArrayElement(External.theLineLength, 0);
                    External.TRI_GetImageDimensions(External.theHandle, intPtr4, intPtr5);
                    string _Boyut = string.Empty;
                    if (External.TRI_GetSensorType(External.theHandle) != EnumManager.TRI_tSensorType.TRI_SIZE1_SMALL)
                    {
                        _Boyut = "LARGE [ 1246 * 1650 ]";
                    }
                    else
                    {
                        _Boyut = "SMALL [ 1440 * 2148 ]";
                    }
                    External.sensorSize = _Boyut;

                    //***********************************************
                    //// eşik seviyesi
                    //IntPtr intPtr6 = Marshal.UnsafeAddrOfPinnedArrayElement(External.theThreshold, 0);
                    //External.TRI_GetThresholdLevel(External.theHandle, intPtr6);
                    //string _ThresHold = External.theThreshold[0].ToString();
                    //External.thresHold = _ThresHold;
                    var _threshold = setsList.Find(t => t.Key == "Threshold");
                    if (_threshold != null)
                    {
                        External.theThreshold[0] = Convert.ToByte(_threshold.Value);
                    }
                    else
                    {
                        External.theThreshold[0] = 10;
                    }
                    string _ThresHold = External.theThreshold[0].ToString();
                    External.thresHold = _ThresHold;

                    //***********************************************
                    // zaman aşımı
                    ////string _Timeout = string.Concat(External.theTimeOut[0].tv_sec.ToString(), " s");
                    ////External.timeOut = _Timeout;
                    //External.theTimeOut[0].tv_sec = 15;
                    //External.theTimeOut[0].tv_usec = 0;
                    //External.timeOut = External.theTimeOut[0].tv_sec.ToString();

                    var _timeOut = setsList.Find(t => t.Key == "TimeOut");
                    if (_timeOut != null)
                    {
                        External.theTimeOut[0].tv_sec = Convert.ToUInt32(_timeOut.Value);
                    }
                    else
                    {
                        External.theTimeOut[0].tv_sec = 15;
                    }
                    External.theTimeOut[0].tv_usec = 0;
                    External.timeOut = External.theTimeOut[0].tv_sec.ToString();


                    //***********************************************
                    // entegrasyon süresi
                    IntPtr intPtr2 = Marshal.UnsafeAddrOfPinnedArrayElement(External.IntTime, 0);
                    External.TRI_GetIntegrationTime(External.theHandle, intPtr2);
                    ushort uInt16 = Convert.ToUInt16(External.IntTime[0]);
                    string _IntTimeDefault = uInt16.ToString(); // ms cinsinden
                    External.intTime = _IntTimeDefault;
                    

                    // sensör bilgileri başarıyla alındı
                    return true;
                }
            }
        }

        private void GetRvgSettings()
        {

            setsList = new List<SettingsItem>();
            setsList.Clear();

            var ayar = db.GetDataTable("Select ID, sKey, sValue From Ayarlar");

            for (int i = 0; i < ayar.Rows.Count; i++)
            {
                SettingsItem item = new SettingsItem();
                item.Id = Convert.ToInt32(ayar.Rows[i]["ID"].ToString());
                item.Key = ayar.Rows[i]["sKey"].ToString();
                item.Value = ayar.Rows[i]["sValue"].ToString();
                setsList.Add(item);
            }
        }*/
    }
}