using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SN.Food.WF.Demo.ComConfig
{
    public partial class FormComConfig : Form
    {
        /********************** 定义该类的私有成员 **************************/

        /// <summary>
        /// 定义一个队列，用于记录用户创建的线程
        /// 以便在窗体关闭的时候关闭所有用于创建的线程
        /// </summary>
        private List<Thread> ChaosThreadList;

        /********************** 该类的初始化相关函数 ************************/


        public delegate void MyInvoke(string str1, string str2);
        public FormComConfig()
        {
            InitializeComponent();
            ChaosThreadList = new List<Thread>();
        }

        /**************************** 定义该类的自定义函数 ***********************/

        /// <summary>
        /// 定义一个代理
        /// </summary>
        /// <param name="dateTime">时间</param>
        /// <param name="weight">重量</param>
        private delegate void DispWeightDelegate(DateTime dateTime, string weight);

        /// <summary>
        /// 定义一个代理
        /// </summary>
        /// <param name="weight">重量</param>
        private delegate void DispShowWeightDelegate(string weight);


        /// <summary>
        /// 定义一个函数，用于向窗体上的ListView控件添加内容
        /// </summary>
        /// <param name="iIndex"></param>
        /// <param name="strMsg"></param>
        private void DispWeight(DateTime dateTime, string weight)
        {
            if (this.lstMain.InvokeRequired == false)                      //如果调用该函数的线程和控件lstMain位于同一个线程内
            {
                //直接将内容添加到窗体的控件上
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = dateTime.ToString("yyyy-MM-dd hh:mm:ss.fff");
                lvi.SubItems.Add(weight);
                this.lstMain.Items.Insert(0, lvi);
            }
            else                                                        //如果调用该函数的线程和控件lstMain不在同一个线程
            {
                //通过使用Invoke的方法，让子线程告诉窗体线程来完成相应的控件操作
                DispWeightDelegate DWD = new DispWeightDelegate(DispWeight);

                //使用控件lstMain的Invoke方法执行DMSGD代理(其类型是DispMSGDelegate)
                this.lstMain.Invoke(DWD, dateTime, weight);
            }
        }

        /// <summary>
        /// 定义一个函数，用于向窗体上的ListView控件添加内容
        /// </summary>
        /// <param name="strMsg"></param>
        private void DispShowWeight(string weight)
        {
            if (this.lstMain.InvokeRequired == false)                      
            {
                this.tbShowWeigth.Text = weight;
            }
            else                                                        
            {
                //通过使用Invoke的方法，让子线程告诉窗体线程来完成相应的控件操作
                DispShowWeightDelegate DWD = new DispShowWeightDelegate(DispShowWeight);

                //使用控件lstMain的Invoke方法执行DMSGD代理(其类型是DispMSGDelegate)
                this.lstMain.Invoke(DWD, weight);
            }
        }

        /// <summary>
        /// 定义一个线程函数，用于循环向列表中添加数据
        /// </summary>
        private void Thread_DisplayWeight()
        {
            for (int i = 0; i < 10; i++)
            {
                DispWeight(DateTime.Now, GenWeight(110).ToString("f1"));
                DispShowWeight(GenWeight(110).ToString("f2"));
                Thread.Sleep(200);
            }
        }

        /******************************* 定义该类的事件处理函数 ********************************/



        /// <summary>
        /// 窗体的关闭事件处理函数，在该事件中将之前创建的线程全部终止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ChaosThreadList.Count > 0)
            {
                //编列自定义队列,将所有线程终止
                foreach (Thread tWorkingThread in ChaosThreadList)
                {
                    tWorkingThread.Abort();
                }
            }
        }
         private void btnThread_Click(object sender, EventArgs e)
        {
            //创建一个新的线程
            Thread tWorkingThread = new Thread(Thread_DisplayWeight);

            //将新建的线程加入到自定义线程队列中，以便在窗体结束时关闭所有的线程
            ChaosThreadList.Add(tWorkingThread);

            //开启线程
            tWorkingThread.Start();
        }


        #region 测试方法
        public void sow()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.Read();
        }

        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            // 线程暂停 5000 毫秒
            int sleepfor = 200;
            Console.WriteLine("Child Thread Paused for {0} seconds",
                              sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        #endregion


        #region 模拟重量生成
        /// <summary>
        /// 一位小数重量模拟生成
        /// 生成范围为 (mWeight - 1)  ~ (mWeight)
        /// 例如 mWeight = 100 则生成 109.1 ~ 110 的数返回
        /// </summary>
        /// <param name="mWeight">输入的重量</param>
        /// <returns></returns>
        private static double GenWeight(double mWeight)
        {
            Random rm = new Random();
            int zfNum = rm.Next(0, 10);
            Double d = Convert.ToDouble(zfNum) / 10;

            mWeight -= d;
            return mWeight;
        }


        public static void CallToGenWeight_Thread()
        {
            List<double> weightList = new List<double>();
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("GenWeighthread starts");
                var rmNum = GenWeight(110);
                weightList.Add(rmNum);
                // 线程暂停 200 毫秒
                int sleepfor = 200;
                Thread.Sleep(sleepfor);
                Console.WriteLine("GenWeighthread end");

            }
        }


        #endregion


       
    }
}
