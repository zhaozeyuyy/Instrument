///////////////////////////////////////////////////////////////
//***@File Name:IPropertyTable.cs
//***@Discription:通道属性页 根据不同的通道测量类型生产属性页，也根据软件的整体类型生产属性页
//***@Creator: zhaozeyu
//***@Create Data:2021.04.25
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
    public interface IPropertyTable
    {
        #region 参数
        /// <summary>
        /// 属性页配属的通道的测量模式
        /// </summary>
        Mode MeasureMode { get; set; }
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
