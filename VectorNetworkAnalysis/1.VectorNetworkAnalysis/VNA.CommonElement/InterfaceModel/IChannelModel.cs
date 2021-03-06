///////////////////////////////////////////////////////////////
//***@File Name:IChannelModel.cs
//***@Discription:通道接口
//***@Creator: zhaozeyu
//***@Create Data:2021.04.24
//***@Revision History:
//***
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNA.CommonElement
{
    public interface IChannelModel
    {
        #region 参数

        /// <summary>
        /// 通道索引
        /// </summary>
        int ChanIndex { get; set; }

        /// <summary>
        /// 通道是否启用
        /// </summary>
        bool IsEnable { get; set; }

        /// <summary>
        /// 当前通道的测量模式
        /// </summary>
        Mode MeasureMode { get; set; }

        /// <summary>
        /// 通道的激活曲线
        /// </summary>
        int DefaultTrcIndex { get; set; }

        /// <summary>
        /// 属性页，可以用于切换通道测量模式的进行替换
        /// </summary>
        IPropertyTable PropertyTable { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 根据参数名称获取指定类型参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        T GetPropertyValue<T>(string name);

        /// <summary>
        /// 设置指定属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        void SetPropertyValue<T>(string name, T value);

        /// <summary>
        /// 通道根据测量模式生成属性
        /// </summary>
        void InitGenerateProperty();

        #endregion
    }
}
