//********************************************************
//***@File Name:IPropertyManager.cs
//***@Discription:特性管理
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

namespace VNA.CommonElement.InterfaceModel
{
    public interface IPropertyManager
    {
        void GetPropertyValue(string name);
    }
}
