using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BlueMax.Classes;
using BlueMax.DAL;
using System.Runtime.InteropServices;

namespace BlueMax
{
    public partial class SettingsRvg : DevExpress.XtraEditors.XtraForm
    {
        DbContext db = new DbContext();
        string val = BTCore.EncryptToBase64(External.btkNS);

        public SettingsRvg()
        {
            InitializeComponent();
        }

        private void SettingsRvg_Load(object sender, EventArgs e)
        {
            pnlError.Visible = false;
            pnlSettings.Visible = false;

            GetSensorConfig();
        }

        private void GetSensorConfig()
        {

            if (!External.sensorConnection)
            {
                //sensör bulunamaz ise, uyarı panelini göster
                pnlError.Visible = true;
                pnlError.Dock = DockStyle.Top;
            }
            else
            {
                if (val == External.bek)
                {
                    // sensör bilgileri alınmış ise, uyarı panelini gizle
                    pnlError.Visible = false;

                    // ayarlar panelini göster ve yeniden konumlandır.
                    pnlSettings.Visible = true;
                    pnlSettings.Left = 12;
                    pnlSettings.Top = 12;

                    label_NumOfSensors.Text = string.Concat(": ", External.sensorNo.ToString());

                    label_SensorSize.Text = string.Concat(": ", External.sensorSize);

                    label_SN.Text = string.Concat(": ", External.btkNS);

                    label_DigiGain.Text = string.Concat(": ", External.digiGain);

                    label_IntTime.Text = string.Concat(": ", External.intTime, " ms");

                    label_Threshold.Text = string.Concat(": ", External.thresHold);

                    label_readout.Text = string.Concat(": ", External.readOut);

                    label_Timeout.Text = string.Concat(": ", External.timeOut, " sn");
                }
                else
                {
                    //sensör bulunamaz ise, uyarı panelini göster
                    pnlError.Visible = true;
                    pnlError.Dock = DockStyle.Top;

                    labelControl2.Text = string.Concat(labelControl2.Text, " / Hata No: SN Not Found ");
                }
            }
        }

        private void btnSetThreshold_Click(object sender, EventArgs e)
        {
            string newValue = txtThreshold.Text;
            int value = 0;

            if (!string.IsNullOrEmpty(newValue))
            {
                try
                {
                    value = Convert.ToUInt16(newValue);
                    if (value > 255)
                    {
                        XtraMessageBox.Show("Lütfen 255 den küçük bir değer giriniz.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // database kaydet
                        string thresHoldId = db.GetDataCell("Select ID From Ayarlar Where sKey='Threshold'");
                        if (!string.IsNullOrEmpty(thresHoldId))
                        {
                            byte b = Convert.ToByte(value);
                            External.TRI_SetThresholdLevel(External.theHandle, b);
                            External.theThreshold[0] = b;
                            External.thresHold = b.ToString();

                            int Id = Convert.ToInt32(thresHoldId);
                            int result = db.Cmd("UPDATE Ayarlar Set sValue='" + newValue + "' Where ID=" + Id + "");

                            XtraMessageBox.Show("Eşik Seviyesinin Değeri Başarıyla Değiştirildi.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetSensorConfig();
                        }
                    }
                }
                catch (Exception exp)
                {
                    XtraMessageBox.Show(exp.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen Eşik Seviyesinin yeni değerini giriniz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region DefaultConfig

        // Threshold
        // TimeOut
        // DigiGain
        // IntegrationTime

        private void SetDefaultSettings()
        {
            try
            {
                var getConfig = db.GetDataTable("Select ID, sKey, sValue From Ayarlar");

                // eski kayıtları sil
                for (int i = 0; i < getConfig.Rows.Count; i++)
                {
                    int recId = Convert.ToInt32(getConfig.Rows[i]["ID"].ToString());

                    int res = db.Cmd("DELETE FROM Ayarlar Where ID=" + recId + "");
                }

                // yeni ayarları kaydet
                int val1 = db.Cmd("Insert Into Ayarlar(sKey, sValue) Values('Threshold', '10')");
                int val2 = db.Cmd("Insert Into Ayarlar(sKey, sValue) Values('TimeOut', '15')");
                int val3 = db.Cmd("Insert Into Ayarlar(sKey, sValue) Values('DigiGain', '1')");
                int val4 = db.Cmd("Insert Into Ayarlar(sKey, sValue) Values('IntegrationTime', '500')");

                // Threshold
                External.TRI_SetThresholdLevel(External.theHandle, 10);
                External.theThreshold[0] = 10;
                External.thresHold = "10";

                // timeout
                External.theTimeOut[0].tv_sec = 15;
                External.timeOut = "15";

                // digigain
                External.TRI_SetDigitalGain(External.theHandle, 1);
                External.DigiGain[0] = 1;
                External.digiGain = "1";

                // integrationTime
                External.TRI_SetIntegrationTime(External.theHandle, 500);
                External.IntTime[0] = 500;
                External.intTime = "500";


                GetSensorConfig();

                XtraMessageBox.Show("Cihaz ayarları varsayılan ayarlar ile değiştirildi.", "AYARLARI SIFIRLA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void btnDefSettings_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Varsayılan cihaz ayarları uygulanacaktır. Onaylıyor musunuz?", "AYARLARI SIFIRLA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                SetDefaultSettings();
            }
        }

        private void btnSetGain_Click(object sender, EventArgs e)
        {
            float single;
            int value = 0;
            string newValue = txtDigiGain.Text;

            if (!string.IsNullOrEmpty(newValue))
            {
                try
                {
                    value = Convert.ToInt32(newValue);

                    if (value > 16)
                    {
                        XtraMessageBox.Show("Dijital Kazanç Değeri en fazla 16 olabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // database kaydet
                        string digiDainId = db.GetDataCell("Select ID From Ayarlar Where sKey='DigiGain'");
                        if (!string.IsNullOrEmpty(digiDainId))
                        {
                            single = Convert.ToSingle(newValue);
                            External.TRI_SetDigitalGain(External.theHandle, single);
                            External.DigiGain[0] = single;
                            External.digiGain = single.ToString();

                            int Id = Convert.ToInt32(digiDainId);
                            int result = db.Cmd("UPDATE Ayarlar Set sValue='" + newValue + "' Where ID=" + Id + "");
                        }

                        XtraMessageBox.Show("Dijital Kazanç Başarıyla Değiştirildi.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetSensorConfig();
                    }
                }
                catch (Exception exp)
                {
                    XtraMessageBox.Show(exp.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen Dijital Kazanç yeni değerini giriniz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetIntTime_Click(object sender, EventArgs e)
        {
            ushort uInt16;

            string newValue = txtIntTime.Text;

            if (!string.IsNullOrEmpty(newValue))
            {
                try
                {
                    uInt16 = Convert.ToUInt16(txtIntTime.Text);

                    if (uInt16 > 3200)
                    {
                        XtraMessageBox.Show("Entegrasyon süresinin değeri en fazla 3200 olabilir.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // database kaydet
                        string intTimeId = db.GetDataCell("Select ID From Ayarlar Where sKey='IntegrationTime'");
                        if (!string.IsNullOrEmpty(intTimeId))
                        {
                            External.TRI_SetIntegrationTime(External.theHandle, uInt16);
                            External.IntTime[0] = uInt16;
                            External.intTime = uInt16.ToString();

                            int Id = Convert.ToInt32(intTimeId);
                            int result = db.Cmd("UPDATE Ayarlar Set sValue='" + newValue + "' Where ID=" + Id + "");

                            XtraMessageBox.Show("Entegrasyon Süresi Başarıyla Değiştirildi.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetSensorConfig();
                        }
                    }
                }
                catch (Exception exp)
                {
                    XtraMessageBox.Show(exp.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen Entegrasyon Süresinin yeni değerini giriniz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetTimeOut_Click(object sender, EventArgs e)
        {
            string newValue = txtTimeOut.Text;

            if (!string.IsNullOrEmpty(newValue))
            {
                // database kaydet
                string timeOutId = db.GetDataCell("Select ID From Ayarlar Where sKey='TimeOut'");
                if (!string.IsNullOrEmpty(timeOutId))
                {
                    UInt32 value = Convert.ToUInt32(newValue);
                    External.theTimeOut[0].tv_sec = value;
                    External.timeOut = newValue;

                    int Id = Convert.ToInt32(timeOutId);
                    int result = db.Cmd("UPDATE Ayarlar Set sValue='" + newValue + "' Where ID=" + Id + "");

                    XtraMessageBox.Show("Entegrasyon Süresi Başarıyla Değiştirildi.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetSensorConfig();
                }
            }
        }

        private string NameIsNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "NULL";
            }
            else
            {
                return value;
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string username = NameIsNull(txtUserName.Text.TrimStart().TrimEnd());
            string password = NameIsNull(txtPassword.Text.TrimStart().TrimEnd());

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            //    XtraMessageBox.Show("Kullanıcı adı veya Parola alanını boş bıraktınız.","HATA !",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
                DialogResult dialogResult = XtraMessageBox.Show("Bilgilerin değiştirilmesi için lütfen onay veriniz.", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var getMember = db.GetDataTable("Select ID, uName, uPass From Users");

                        for (int i = 0; i < getMember.Rows.Count; i++)
                        {
                            int recId = Convert.ToInt32(getMember.Rows[i]["ID"].ToString());

                            int res = db.Cmd("DELETE FROM Users Where ID=" + recId + "");
                        }

                        int record = db.Cmd("Insert Into Users(uName, uPass) Values('" + username + "', '" + password + "')");

                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;

                        XtraMessageBox.Show("Kullanıcı bilgileri değiştirildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            //}
        }
    }
}