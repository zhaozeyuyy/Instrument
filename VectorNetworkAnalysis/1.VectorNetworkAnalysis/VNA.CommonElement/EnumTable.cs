//////////////////////////////////////////////////////////////
//***@File Name:EnumTable.cs
//***@Discription:所有enum类型
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
    /// <summary>
    /// 测量模式的所有类型
    /// </summary>
    public enum Mode
    { 
        STD,
    }

    /// <summary>
    /// marker显示的格式类型
    /// </summary>
    public enum MarkerFormat
    { 
        RealImag,
        LinMagPhase,
        LogMagPhase,
        Rjx,
        Gjb,
        SWRPhase,
    }
}
