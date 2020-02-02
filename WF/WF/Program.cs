using Gtk;
using System;

namespace WF
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();//初始化

            var win = new Window("Hello World");//新建窗体，标题是Hello World
            win.WindowPosition = WindowPosition.Center;
            win.DefaultHeight = 768;
            win.DefaultWidth = 1024;

            var lable = new Label("亮度增益加测");//新建标签
            lable.Valign = Align.Start;
            lable.Halign = Align.Center;
            lable.Ypad = 20;
            

            

            win.Add(lable);//将标签加入到窗体
            win.ShowAll();//显示窗体
            Application.Run();//运行窗体 
            //Console.WriteLine("Hello World!");
        }
    }
}
