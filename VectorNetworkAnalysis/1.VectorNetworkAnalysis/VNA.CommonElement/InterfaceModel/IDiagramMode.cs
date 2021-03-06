///////////////////////////////////////////////////////////////
//***@File Name:IDiagramMode.cs
//***@Discription:曲线的接口
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
    public interface IDiagramMode
    {
        #region 参数

        /// <summary>
        /// 曲线索引
        /// </summary>
        int DiagIndex { get; set; }

        /// <summary>
        /// Diag是否启用
        /// </summary>
        bool IsEnable { get; set; }

        /// <summary>
        /// diag的默认曲线
        /// </summary>
        int DefaultTrcIndex { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}
