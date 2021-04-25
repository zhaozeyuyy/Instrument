///////////////////////////////////////////////////////////////
//***@File Name:ITraceManagerMode.cs
//***@Discription:曲线管理总类接口
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
    public interface ITraceManagerMode
    {
        #region 参数
        /// <summary>
        /// 默认迹线的索引 可以没有，为-1
        /// </summary>
        int CurrActiveTrcIndex { get; set; }

        /// <summary>
        /// 曲线的数组
        /// </summary>
        ITraceMode[] TraceTable { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// 通过曲线索引得到曲线
        /// </summary>
        /// <param name="trcIndex"></param>
        /// <returns></returns>
        ITraceMode GetTraceByIndex(int trcIndex);

        /// <summary>
        /// 获取默认曲线
        /// </summary>
        /// <returns></returns>
        ITraceMode GetDefaultTrace();

        /// <summary>
        /// 添加默认曲线
        /// </summary>
        /// <returns></returns>
        bool AddDefaultTrace();

        /// <summary>
        /// 通过迹线索引添加极限
        /// </summary>
        /// <param name="trcIndex"></param>
        /// <returns></returns>
        bool AddTraceByIndex(int trcIndex);

        /// <summary>
        /// 删除默认激活迹线
        /// </summary>
        /// <returns></returns>
        bool DeleteDefaultTrace();

        /// <summary>
        /// 删除指定索引的迹线
        /// </summary>
        /// <param name="trcIndex"></param>
        /// <returns></returns>
        bool DeleteTraceByIndex(int trcIndex);

        /// <summary>
        /// 激活指定曲线
        /// </summary>
        /// <param name="trcIndex"></param>
        void ActiveTraceByIndex(int trcIndex);

        #endregion
    }
}
