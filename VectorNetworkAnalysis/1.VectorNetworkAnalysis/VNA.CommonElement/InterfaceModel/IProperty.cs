//********************************************************
//***@File Name:IProperty.cs
//***@Discription:特性接口
//***@Creator: zhaozeyu
//***@Create Data:2021.04.24
//***@Revision History:
//***
//********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNA.CommonElement
{
    public interface IProperty<T>
    {
        #region 参数
        /// <summary>
        /// 属性名称
        /// </summary>
        string PropertyName { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 获取指定的属性值
        /// </summary>
        /// <returns></returns>
        T GetValue();
        #endregion
    }
}
