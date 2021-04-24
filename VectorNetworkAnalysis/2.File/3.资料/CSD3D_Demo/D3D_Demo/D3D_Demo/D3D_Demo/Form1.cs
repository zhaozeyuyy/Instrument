using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace D3D_Demo
{
    public partial class Form1 : Form
    {
        Device device1;
        Device device2;
        public Form1()
        {
            InitializeComponent();
            InitializeDirect3D();
        }
        public bool InitializeDirect3D()
        {
            try
            {
                PresentParameters presentParams = new PresentParameters();
                presentParams.Windowed = true; //指定以Windows窗体形式显示 
                presentParams.SwapEffect = SwapEffect.Discard; //当前屏幕绘制后,它将自动从内存中删除
                device1 = new Device(0, DeviceType.Hardware, this.panel1, CreateFlags.SoftwareVertexProcessing, presentParams); //实例化device对象 
                device2 = new Device(0, DeviceType.Hardware, this.panel2, CreateFlags.SoftwareVertexProcessing, presentParams); //实例化device对象 
                return true;
            }
            catch (DirectXException e)
            {
                MessageBox.Show(e.ToString(), "Error"); //处理异常 
                return false;
            }
        }
        public void Render1()
        {
            if (device1 == null)   //如果device为空则不渲染 
            {
                return;
            }
            device1.Clear(ClearFlags.Target, Color.DarkSlateBlue, 1.0f, 0);  //清除windows界面为深蓝色 
            device1.BeginScene();
            {
                //在此添加渲染图形代码 
                CustomVertex.TransformedColored[] vertices = new
                CustomVertex.TransformedColored[3];//定义顶点 
                vertices[0].Position = new Vector4(150f, 400f, 0f, 1f);
                vertices[0].Color = Color.Red.ToArgb();
                vertices[1].Position = new Vector4(panel1.Width / 2, 100f, 0f, 1f);
                vertices[1].Color = Color.Green.ToArgb();
                vertices[2].Position = new Vector4(panel1.Width - 150f, 400f, 0f, 1f);
                vertices[2].Color = Color.Yellow.ToArgb();
                device1.VertexFormat = CustomVertex.TransformedColored.Format;
                device1.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices);

                Surface backbuffer = device1.GetBackBuffer(0, 0, BackBufferType.Mono);
                SurfaceLoader.Save("Screenshot1.bmp", ImageFileFormat.Bmp, backbuffer);                
                
            }
            device1.EndScene();
            device1.Present();
        }
        public void Render2()
        {
            if (device2 == null)   //如果device为空则不渲染 
            {
                return;
            }
            device2.Clear(ClearFlags.Target, Color.DarkSlateBlue, 1.0f, 0);  //清除windows界面为深蓝色 
            device2.BeginScene();
            {
                //在此添加渲染图形代码 
                CustomVertex.TransformedColored[] vertices = new CustomVertex.TransformedColored[4];//定义顶点 
                vertices[0].Position = new Vector4(150f, 400f, 0f, 1f);
                vertices[0].Color = Color.Yellow.ToArgb();
                vertices[1].Position = new Vector4(panel2.Width / 2, 100f, 0f, 1f);
                vertices[1].Color = Color.Green.ToArgb();
                vertices[2].Position = new Vector4(panel2.Width - 150f, 400f, 0f, 1f);
                vertices[2].Color = Color.Red.ToArgb();
                
                device2.VertexFormat = CustomVertex.TransformedColored.Format;
                device2.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices);
                //截取panel2的截图
                Surface backbuffer = device2.GetBackBuffer(0, 0, BackBufferType.Mono);
                SurfaceLoader.Save("Screenshot2.bmp", ImageFileFormat.Bmp, backbuffer);

            }
            device2.EndScene();
            device2.Present();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Render1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Render2();
        }
    }
}
