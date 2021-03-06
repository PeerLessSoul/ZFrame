﻿using Entity.SYS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ZFrameCore.BLL;
namespace BLL.SYS
{
    public class T_SYS_Function_BLL : TBLLBase<T_SYS_Function>
    {
        public T_SYS_Function_BLL()
        {
            ///业务对象初始化SQL
            this.SQLString = @"Select * , dbo.FN_GetSPY(F_Name) AS F_FilterKey FROM T_SYS_Function";
            //默认拉取逻辑未删除数据
            this.WhereStr = "F_ISDEL=0";
            //默认排序为创建时间倒序
            this.OrderStr = "F_Index";
        }
    }
}

