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
        /// <summary>
        /// 通道索引
        /// </summary>
        int ChanIndex { get; set; }


    }
}
