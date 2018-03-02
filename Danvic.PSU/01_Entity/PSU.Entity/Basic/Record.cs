﻿//-----------------------------------------------------------------------
// <copyright file= "Record.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/3/2 星期五 9:07:53
// Modified by:
// Description: 账号操作记录表
//-----------------------------------------------------------------------
using PSU.Utility.System;
using System.ComponentModel.DataAnnotations;

namespace PSU.Entity.Basic
{
    public class Record
    {
        #region Attrbite

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public string RecordOID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        public long Id { get; set; } = TimeUtility.GetTimespans();

        /// <summary>
        /// 操作人姓名
        /// </summary>
        [MaxLength(50)]
        public string UserName { get; set; }

        #endregion
    }
}
