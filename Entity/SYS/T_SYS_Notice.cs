﻿using ZFrameCore.Entity;
using System;
namespace Entity.SYS
{
  
    /// <summary> 实体名称
    /// </summary>
    public class  T_SYS_Notice : TEntityBase
    {
          #region 数据库字段对应
          
          private Guid _F_SN;
        
          /// <summary>
           /// </summary>
          public Guid F_SN {get{return _F_SN;}set{ if(_F_SN!=value){_F_SN=value;if(SendNotifyProperty)this.SendPropertyChanged("F_SN");}}}
          
          private Guid _F_ParentSN;
        
          /// <summary>
           /// </summary>
          public Guid F_ParentSN {get{return _F_ParentSN;}set{ if(_F_ParentSN!=value){_F_ParentSN=value;if(SendNotifyProperty)this.SendPropertyChanged("F_ParentSN");}}}
          
          private int? _F_Type;
        
          /// <summary>
           /// </summary>
          public int? F_Type{get{return _F_Type;}set{ if(_F_Type!=value){_F_Type=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Type");}}}
          
          private string _F_Code;
        
          /// <summary>
           /// </summary>
          public string F_Code{get{return _F_Code;}set{ if(_F_Code!=value){_F_Code=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Code");}}}
          
          private string _F_Name;
        
          /// <summary>
           /// </summary>
          public string F_Name{get{return _F_Name;}set{ if(_F_Name!=value){_F_Name=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Name");}}}
          
          private string _F_Color;
        
          /// <summary>
           /// </summary>
          public string F_Color{get{return _F_Color;}set{ if(_F_Color!=value){_F_Color=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Color");}}}
          
          private string _F_Contend;
        
          /// <summary>
           /// </summary>
          public string F_Contend{get{return _F_Contend;}set{ if(_F_Contend!=value){_F_Contend=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Contend");}}}
          
          private DateTime? _F_StartDate;
        
          /// <summary>
           /// </summary>
          public DateTime? F_StartDate{get{return _F_StartDate;}set{ if(_F_StartDate!=value){_F_StartDate=value;if(SendNotifyProperty)this.SendPropertyChanged("F_StartDate");}}}
          
          private DateTime? _F_EndDate;
        
          /// <summary>
           /// </summary>
          public DateTime? F_EndDate{get{return _F_EndDate;}set{ if(_F_EndDate!=value){_F_EndDate=value;if(SendNotifyProperty)this.SendPropertyChanged("F_EndDate");}}}
          
          private bool? _F_IsTop;
        
          /// <summary>
           /// </summary>
          public bool? F_IsTop{get{return _F_IsTop;}set{ if(_F_IsTop!=value){_F_IsTop=value;if(SendNotifyProperty)this.SendPropertyChanged("F_IsTop");}}}
          
          private string _F_Remark;
        
          /// <summary>
           /// </summary>
          public string F_Remark{get{return _F_Remark;}set{ if(_F_Remark!=value){_F_Remark=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Remark");}}}
          
          private int? _F_State;
        
          /// <summary>
           /// </summary>
          public int? F_State{get{return _F_State;}set{ if(_F_State!=value){_F_State=value;if(SendNotifyProperty)this.SendPropertyChanged("F_State");}}}
          
          private int? _F_Index;
        
          /// <summary>
           /// </summary>
          public int? F_Index{get{return _F_Index;}set{ if(_F_Index!=value){_F_Index=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Index");}}}
          
          private bool? _F_IsDel;
        
          /// <summary>
           /// </summary>
          public bool? F_IsDel{get{return _F_IsDel;}set{ if(_F_IsDel!=value){_F_IsDel=value;if(SendNotifyProperty)this.SendPropertyChanged("F_IsDel");}}}
          
          private Guid _F_Creator;
        
          /// <summary>
           /// </summary>
          public Guid F_Creator {get{return _F_Creator;}set{ if(_F_Creator!=value){_F_Creator=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Creator");}}}
          
          private DateTime? _F_CreateDate;
        
          /// <summary>
           /// </summary>
          public DateTime? F_CreateDate{get{return _F_CreateDate;}set{ if(_F_CreateDate!=value){_F_CreateDate=value;if(SendNotifyProperty)this.SendPropertyChanged("F_CreateDate");}}}
          
          private Guid _F_Updater;
        
          /// <summary>
           /// </summary>
          public Guid F_Updater {get{return _F_Updater;}set{ if(_F_Updater!=value){_F_Updater=value;if(SendNotifyProperty)this.SendPropertyChanged("F_Updater");}}}
          
          private DateTime? _F_UpdateDate;
        
          /// <summary>
           /// </summary>
          public DateTime? F_UpdateDate{get{return _F_UpdateDate;}set{ if(_F_UpdateDate!=value){_F_UpdateDate=value;if(SendNotifyProperty)this.SendPropertyChanged("F_UpdateDate");}}}
          
          
          #endregion
    }
}

