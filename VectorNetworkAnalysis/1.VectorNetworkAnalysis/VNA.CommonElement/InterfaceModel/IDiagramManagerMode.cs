///////////////////////////////////////////////////////////////
//***@File Name:IDiagramManagerMode.cs
//***@Discription:diag管理总类接口
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

namespace VNA.CommonElement.InterfaceModel
{
    public interface IDiagramManagerMode
    {
        #region 参数
        /// <summary>
        /// 默认diagram的索引 可以没有，为-1
        /// </summary>
        int CurrActiveDiagIndex { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 通过diagram索引得到diagram
        /// </summary>
        /// <param name="diagIndex"></param>
        /// <returns></returns>
        IDiagramMode GetDiagramByIndex(int diagIndex);

        /// <summary>
        /// 获取默认diagram
        /// </summary>
        /// <returns></returns>
        IDiagramMode GetDefaultDiagram();

        /// <summary>
        /// 添加默认diagram
        /// </summary>
        /// <returns></returns>
        bool AddDefaultDiagram();

        /// <summary>
        /// 通过diagram索引添加diagram
        /// </summary>
        /// <param name="diagIndex"></param>
        /// <returns></returns>
        bool AddDiagramByIndex(int diagIndex);

        /// <summary>
        /// 删除默认激活diagram
        /// </summary>
        /// <returns></returns>
        bool DeleteDefaultDiagram();

        /// <summary>
        /// 删除指定索引的diagram
        /// </summary>
        /// <param name="diagIndex"></param>
        /// <returns></returns>
        bool DeleteDiagramByIndex(int diagIndex);
        #endregion
    }
}
