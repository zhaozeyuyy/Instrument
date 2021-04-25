///////////////////////////////////////////////////////////////
//***@File Name:IChannelManagerMode.cs
//***@Discription:通道管理总类接口
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
    public interface IChannelManagerMode
    {
        #region 参数

        /// <summary>
        /// 默认通道的索引 可以没有，为-1
        /// </summary>
        int CurrActiveChanIndex { get; set; }

        /// <summary>
        /// 所有通道的通道数组
        /// </summary>
        IChannelModel[] ChannelTable { get; set; }
        #endregion

        #region 方法

        /// <summary>
        /// 通过通道索引获取指定通道
        /// </summary>
        /// <param name="chanIndex"></param>
        /// <returns></returns>
        IChannelModel GetChannelByIndex(int chanIndex);

        /// <summary>
        /// 获取默认通道
        /// </summary>
        /// <returns>通道</returns>
        IChannelModel GetDefaultChannel();

        /// <summary>
        /// 添加默认通道
        /// </summary>
        /// <returns></returns>
        bool AddDefaultChannel();

        /// <summary>
        /// 通过迹通道索引添加通道
        /// </summary>
        /// <param name="chanIndex">通道索引</param>
        /// <returns></returns>
        bool AddChannelByIndex(int chanIndex);

        /// <summary>
        /// 删除默认激活迹线
        /// </summary>
        /// <returns></returns>
        bool DeleteDefaultChannel();

        /// <summary>
        /// 删除指定索引的通道
        /// </summary>
        /// <param name="chanIndex">通道索引</param>
        /// <returns></returns>
        bool DeleteChannelByIndex(int chanIndex);

        /// <summary>
        /// 根据索引激活通道
        /// </summary>
        /// <param name="chanIndex"></param>
        void ActiveChannelByIndex(int chanIndex);
        #endregion
    }
}
