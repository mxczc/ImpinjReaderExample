using Impinj.OctaneSdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpinjReaderExample
{
    /// <summary>
    /// 作者：www.cisharp.com
    /// 描述：此示例基于impinj r220或420编写；若其它型号的固定式读写器，请自定义更改。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Impinj.OctaneSdk.ImpinjReader reader;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reader_TagsReported(Impinj.OctaneSdk.ImpinjReader reader, Impinj.OctaneSdk.TagReport report)
        {
            //与界面控件交互需要Invoke
            this.Invoke((Action)delegate
            {
                foreach (var item in report.Tags)
                {
                    ri_log.Text += item.Epc.ToHexString() + "\r\n";
                }
            });
        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (btn_conn.Text == "连接")
            {
                reader = new Impinj.OctaneSdk.ImpinjReader();
                //连接读写器
                reader.Connect(txt_ip.Text);
                reader.TagsReported += Reader_TagsReported;
                reader.ReaderStarted += Reader_ReaderStarted;
                reader.ReaderStopped += Reader_ReaderStopped;

                //如果设置文件存在，则应用设置文件
                var path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "settings.xml";
                if (File.Exists(path))
                {
                    Settings settings = Settings.Load(path);
                    reader.ApplySettings(settings);
                }
                btn_conn.Text = "断开";
            }
            else
            {
                reader?.Stop();
                reader?.Disconnect();
                btn_conn.Text = "连接";
            }
        }

        private void Reader_ReaderStopped(ImpinjReader reader, ReaderStoppedEvent e)
        {
            //盘点停止事件通知
        }

        private void Reader_ReaderStarted(ImpinjReader reader, ReaderStartedEvent e)
        {
            //盘点开启事件通知
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            if (reader.IsConnected && btn_inv.Text == "开启盘点")
            {
                reader.Start();
                btn_inv.Text = "停止盘点";
            }
            else
            {
                reader.Stop();
                btn_inv.Text = "开启盘点";
            }
        }

        private void btn_cfg_Click(object sender, EventArgs e)
        {
            if (reader?.IsConnected ?? false)
            {
                //查询读写器已有设置。
                var setting = reader.QuerySettings();

                //---------------------基础设置--------------------------
                //设置天线1相关参数，若有多跟天线同理。
                //天线功率10至30.5之间
                setting.Antennas.AntennaConfigs[0].TxPowerInDbm = 30.5;
                //灵敏度-30至-80之间
                setting.Antennas.AntennaConfigs[0].RxSensitivityInDbm = -80;
                //启用禁用天线
                setting.Antennas.AntennaConfigs[0].IsEnabled = true;
                //是否最大灵敏度
                setting.Antennas.AntennaConfigs[0].MaxRxSensitivity = false;
                //是否最大功率
                setting.Antennas.AntennaConfigs[0].MaxTxPower = false;
                //-------------------------------------------------------


                //---------------------高级设置--------------------------
                ////设置GPI触发盘点以及GPO输出。
                //setting.AutoStart.Mode = AutoStartMode.GpiTrigger;
                //setting.AutoStart.GpiPortNumber = 1;
                //setting.AutoStart.GpiLevel = true;

                ////设置延时停止，即读若干秒停止；配合GPI触发使用。
                //setting.AutoStop.Mode = AutoStopMode.Duration;
                //setting.AutoStop.DurationInMs = 3000;

                ////GPI触发延时，单位毫秒
                //setting.Gpis.GetGpi(1).DebounceInMs = 50;
                ////GPI0号接口
                //setting.Gpis.GetGpi(1).PortNumber = 1;
                //setting.Gpis.GetGpi(1).IsEnabled = true;

                ////GPI触发延时，单位毫秒
                //setting.Gpis.GetGpi(2).DebounceInMs = 50;
                //setting.Gpis.GetGpi(2).IsEnabled = true;
                ////GPI1号接口
                //setting.Gpis.GetGpi(2).PortNumber = 2;

                //setting.Gpis.GetGpi(3).DebounceInMs = 50;
                //setting.Gpis.GetGpi(3).IsEnabled = false;
                //setting.Gpis.GetGpi(3).PortNumber = 3;

                //setting.Gpis.GetGpi(4).DebounceInMs = 50;
                //setting.Gpis.GetGpi(4).IsEnabled = false;
                //setting.Gpis.GetGpi(4).PortNumber = 4;
                ////-------------------------------------------------------

                //应用设置
                reader.ApplySettings(setting);
                //保存设置
                setting.Save(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "settings.xml");
                MessageBox.Show("保存成功");
            }
        }
    }
}
