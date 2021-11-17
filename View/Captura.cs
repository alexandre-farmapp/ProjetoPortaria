using NetSDKCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Portaria.View
{
    public partial class Captura : Form
    {
        #region Field 字段
        private const int m_WaitTime = 5000;
        private const int SyncFileSize = 5 * 1024 * 1204;
        private static fDisConnectCallBack m_DisConnectCallBack;
        private static fHaveReConnectCallBack m_ReConnectCallBack;
        private static fRealDataCallBackEx2 m_RealDataCallBackEx2;
        private static fSnapRevCallBack m_SnapRevCallBack;

        private IntPtr m_LoginID = IntPtr.Zero;
        private NET_DEVICEINFO_Ex m_DeviceInfo;
        private IntPtr m_RealPlayID = IntPtr.Zero;
        private uint m_SnapSerialNum = 1;
        private bool m_IsInSave = false;
        private int SpeedValue = 4;
        private const int MaxSpeed = 8;
        private const int MinSpeed = 1;
        #endregion

        public string ip;
        public string porta;
        public string usuario;
        public string senha;
        public string caminhofoto;

        public Captura()
        {
            InitializeComponent();
            this.Load += new EventHandler(Captura_Load);
            
        }
        
        private void login_button_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero == m_LoginID)
            {
                ushort port = 0;
                try
                {
                    port = Convert.ToUInt16(port_textBox.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Input port error!");
                    return;
                }
                m_DeviceInfo = new NET_DEVICEINFO_Ex();
                m_LoginID = NETClient.Login(ip_textBox.Text.Trim(), port, name_textBox.Text.Trim(), pwd_textBox.Text.Trim(), EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref m_DeviceInfo);
                if (IntPtr.Zero == m_LoginID)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                LoginUI();
                start_realplay_button.Enabled = true;
            }
            else
            {
                bool result = NETClient.Logout(m_LoginID);
                if (!result)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                m_LoginID = IntPtr.Zero;
                InitOrLogoutUI();
            }
        }

        private void start_realplay_button_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero == m_RealPlayID)
            {
                // realplay 监视
                EM_RealPlayType type;
                if (streamtype_comboBox.SelectedIndex == 0)
                {
                    type = EM_RealPlayType.Realplay;
                }
                else
                {
                    type = EM_RealPlayType.Realplay_1;
                }
                m_RealPlayID = NETClient.RealPlay(m_LoginID, channel_comboBox.SelectedIndex, realplay_pictureBox.Handle, type);
                if (IntPtr.Zero == m_RealPlayID)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                NETClient.SetRealDataCallBack(m_RealPlayID, m_RealDataCallBackEx2, IntPtr.Zero, EM_REALDATA_FLAG.DATA_WITH_FRAME_INFO | EM_REALDATA_FLAG.PCM_AUDIO_DATA | EM_REALDATA_FLAG.RAW_DATA | EM_REALDATA_FLAG.YUV_DATA);
                start_realplay_button.Text = "StopReal";
                channel_comboBox.Enabled = false;
                streamtype_comboBox.Enabled = false;
                //save_button.Enabled = true;
            }
            else
            {
                // stop realplay 关闭监视
                bool ret = NETClient.StopRealPlay(m_RealPlayID);
                if (!ret)
                {
                    MessageBox.Show(this, NETClient.GetLastError());
                    return;
                }
                m_RealPlayID = IntPtr.Zero;
                start_realplay_button.Text = "StartReal";
                realplay_pictureBox.Refresh();
                channel_comboBox.Enabled = true;
                streamtype_comboBox.Enabled = true;
                //save_button.Enabled = false;
                if (m_IsInSave)
                {
                    m_IsInSave = false;
                    //save_button.Text = "StartSave(开始保存)";
                }
            }
        }

        private void InitOrLogoutUI()
        {
            //step_comboBox.Enabled = false;
            //step_comboBox.Items.Clear();
            login_button.Text = "Login(登录)";
            channel_comboBox.Items.Clear();
            channel_comboBox.Enabled = false;
            streamtype_comboBox.Items.Clear();
            streamtype_comboBox.Enabled = false;
            start_realplay_button.Enabled = false;
            capture_button.Enabled = false;
            //save_button.Enabled = false;
            /*topleft_button.Enabled = false;
            topright_button.Enabled = false;
            top_button.Enabled = false;
            left_button.Enabled = false;
            right_button.Enabled = false;
            bottom_button.Enabled = false;
            bottomleft_button.Enabled = false;
            bottomright_button.Enabled = false;
            zoomadd_button.Enabled = false;
            zoomdec_button.Enabled = false;
            focusadd_button.Enabled = false;
            focusdec_button.Enabled = false;
            apertureadd_button.Enabled = false;
            aperturedec_button.Enabled = false;*/
            m_RealPlayID = IntPtr.Zero;
            start_realplay_button.Text = "StartReal";
            realplay_pictureBox.Refresh();
            //save_button.Text = "StartSave(开始保存)";
            this.Text = "DooR Portaria ---";
        }

        private void LoginUI()
        {/*
            step_comboBox.Enabled = true;
            for (int i = MinSpeed; i <= MaxSpeed; i++)
            {
                step_comboBox.Items.Add(i);
            }
            step_comboBox.SelectedIndex = SpeedValue - 1;*/
            login_button.Text = "Logout";
            channel_comboBox.Enabled = true;
            streamtype_comboBox.Enabled = true;
            start_realplay_button.Enabled = true;
            capture_button.Enabled = true;/*
            topleft_button.Enabled = true;
            topright_button.Enabled = true;
            top_button.Enabled = true;
            left_button.Enabled = true;
            right_button.Enabled = true;
            bottom_button.Enabled = true;
            bottomleft_button.Enabled = true;
            bottomright_button.Enabled = true;
            zoomadd_button.Enabled = true;
            zoomdec_button.Enabled = true;
            focusadd_button.Enabled = true;
            focusdec_button.Enabled = true;
            apertureadd_button.Enabled = true;
            aperturedec_button.Enabled = true;*/
            for (int i = 1; i <= m_DeviceInfo.nChanNum; i++)
            {
                channel_comboBox.Items.Add(i);
            }
            streamtype_comboBox.Items.Add("Main Stream");
            streamtype_comboBox.Items.Add("Extra Stream");
            channel_comboBox.SelectedIndex = 0;
            streamtype_comboBox.SelectedIndex = 0;
            this.Text = "DooR Portaria --- Online";
        }

        private void Captura_Load(object sender, EventArgs e)
        {
            m_DisConnectCallBack = new fDisConnectCallBack(DisConnectCallBack);
            m_ReConnectCallBack = new fHaveReConnectCallBack(ReConnectCallBack);
            m_RealDataCallBackEx2 = new fRealDataCallBackEx2(RealDataCallBackEx);
            m_SnapRevCallBack = new fSnapRevCallBack(SnapRevCallBack);
            try
            {
                NETClient.Init(m_DisConnectCallBack, IntPtr.Zero, null);
                NETClient.SetAutoReconnect(m_ReConnectCallBack, IntPtr.Zero);
                NETClient.SetSnapRevCallBack(m_SnapRevCallBack, IntPtr.Zero);
                InitOrLogoutUI();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }

            login();            
        }

        private void login()
        {
            ushort port = 0;
            try
            {
                port = Convert.ToUInt16(porta.Trim());
            }
            catch
            {
                MessageBox.Show("Input port error!");
                return;
            }
            m_DeviceInfo = new NET_DEVICEINFO_Ex();
            m_LoginID = NETClient.Login(ip.Trim(), port, usuario.Trim(), senha.Trim(), EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref m_DeviceInfo);
            if (IntPtr.Zero == m_LoginID)
            {
                MessageBox.Show(this, NETClient.GetLastError());
                return;
            }
            LoginUI();
            start_realplay_button.Enabled = true;
        }

        #region CallBack 回调
        private void DisConnectCallBack(IntPtr lLoginID, IntPtr pchDVRIP, int nDVRPort, IntPtr dwUser)
        {
            this.BeginInvoke((Action)UpdateDisConnectUI);
        }

        private void UpdateDisConnectUI()
        {
            this.Text = "DooR Portaria --- Offline";
        }

        private void ReConnectCallBack(IntPtr lLoginID, IntPtr pchDVRIP, int nDVRPort, IntPtr dwUser)
        {
            this.BeginInvoke((Action)UpdateReConnectUI);
        }
        private void UpdateReConnectUI()
        {
            this.Text = "DooR Portaria --- Online";
        }

        private void RealDataCallBackEx(IntPtr lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr param, IntPtr dwUser)
        {
            //do something such as save data,send data,change to YUV. 比如保存数据，发送数据，转成YUV等.
        }

        private void SnapRevCallBack(IntPtr lLoginID, IntPtr pBuf, uint RevLen, uint EncodeType, uint CmdSerial, IntPtr dwUser)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "capture";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (EncodeType == 10) //.jpg
            {
                DateTime now = DateTime.Now;
                string fileName = "async" + CmdSerial.ToString() + ".jpg";
                string filePath = path + "\\" + fileName;
                byte[] data = new byte[RevLen];
                Marshal.Copy(pBuf, data, 0, (int)RevLen);
                using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    stream.Write(data, 0, (int)RevLen);
                    stream.Flush();
                    stream.Dispose();
                }
            }
        }

        #endregion

        private void capture_button_Click(object sender, EventArgs e)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "fotos";
            string path = caminhofoto;

            //if (Projeto_Portaria.Properties.Settings.Default.CaminhoFotos == "")
            //{
            //    MessageBox.Show("Precisamos Escolher o caminho onde sera salvo as capturas!");

            //    if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        Projeto_Portaria.Properties.Settings.Default.CaminhoFotos = folderBrowserDialog1.SelectedPath;
            //    }
            //}


            #region client capture 本地抓图
            if (IntPtr.Zero == m_RealPlayID)
            {
                MessageBox.Show(this, "Por Favor Inicie ao vivo primeiro!");
                return;
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            DateTime now = DateTime.Now;
            //string filePath = path + "\\" + "client" + m_SnapSerialNum.ToString() + ".jpg";
            string filePath = path + "\\" + string.Format("{0}-{1}-{2}-{3}-{4}", now.Day, now.Month, now.Year, now.Hour, now.Minute) + ".jpg";

            bool result = NETClient.CapturePicture(m_RealPlayID, filePath, EM_NET_CAPTURE_FORMATS.JPEG);
            if (!result)
            {
                MessageBox.Show(this, NETClient.GetLastError());
                return;
            }
            MessageBox.Show(this, "foto capturada!");
            #endregion

            caminhofoto = filePath;

            this.Close();
                        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
