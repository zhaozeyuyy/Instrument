//********************************************************
//***@File Name:ITraceMode.cs
//***@Discription:曲线的接口
//***@Creator: zhaozeyu
//***@Create Data:2021.04.24
//***@Revision History:
//********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNA.CommonElement
{
    public interface ITraceMode
    {
        #region 参数
        /// <summary>
        /// 曲线索引
        /// </summary>
        int TrcIndex { get; set; }

        /// <summary>
        /// 所属通道索引
        /// </summary>
        int ChanIndex { get; set; }

        /// <summary>
        /// 所属图表的索引
        /// </summary>
        int DiagIndex { get; set; }
        #endregion

        #region 方法
        #endregion
    }
}
