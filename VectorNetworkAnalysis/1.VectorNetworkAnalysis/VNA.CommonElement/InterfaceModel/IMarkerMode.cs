﻿//********************************************************
//***@File Name:IMarkerModel.cs
//***@Discription:marker接口
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
    public interface IMarkerModel
    {
        #region 参数
        /// <summary>
        /// marker的索引
        /// </summary>
        int MkrIndex { get; set; }

        /// <summary>
        /// marker所属曲线索引
        /// </summary>
        int TrcIndex { get; set; }
        #endregion

        #region 方法
        #endregion
    }
}
