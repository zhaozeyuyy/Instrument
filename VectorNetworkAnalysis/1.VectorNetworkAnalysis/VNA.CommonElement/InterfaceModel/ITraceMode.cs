///////////////////////////////////////////////////////////////
//***@File Name:ITraceMode.cs
//***@Discription:曲线的接口
//***@Creator: zhaozeyu
//***@Create Data:2021.04.24
//***@Revision History:
///////////////////////////////////////////////////////////////

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
        /// 曲线是否启用
        /// </summary>
        bool IsEnable { get; set; }

        /// <summary>
        /// 所属通道索引
        /// </summary>
        int ChanIndex { get; set; }

        /// <summary>
        /// 所属图表的索引
        /// </summary>
        int DiagIndex { get; set; }

        /// <summary>
        /// 默认marker
        /// </summary>
        int MarkerIndex { get; set; }

        /// <summary>
        /// 曲线的marker表，曲线的所有marker
        /// </summary>
        IMarkerModel[] MarkerTable { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 设置曲线通道
        /// </summary>
        /// <param name="chanIndex"></param>
        void SetChannel(int chanIndex);

        /// <summary>
        /// 设置曲线Diagram
        /// </summary>
        /// <param name="diagIndex"></param>
        void SetDiagram(int diagIndex);

        /// <summary>
        /// 获取指定索引marker
        /// </summary>
        /// <param name="markerIndex"></param>
        /// <returns></returns>
        IMarkerModel GetMarker(int markerIndex);

        /// <summary>
        /// 获取默认的marker
        /// </summary>
        /// <returns></returns>
        IMarkerModel GetDefaultMarker();
        #endregion
    }
}
