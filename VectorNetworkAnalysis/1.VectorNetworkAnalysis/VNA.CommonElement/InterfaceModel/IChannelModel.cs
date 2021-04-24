//********************************************************
//***@File Name:IChannelModel.cs
//***@Discription:通道接口
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
    public interface IChannelModel
    {
        #region 参数

        /// <summary>
        /// 通道索引
        /// </summary>
        int ChanIndex { get; set; }
        #endregion

        #region 方法

        /// <summary>
        /// 获取指定特性
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        Object GetPropertys(string Name);

        #endregion
    }
}
