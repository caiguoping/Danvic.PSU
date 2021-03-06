﻿//-----------------------------------------------------------------------
// <copyright file= "IHomeService.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/2/27 星期二 15:04:25
// Modified by:
// Description: Administrator-Home控制器邻域功能接口
//-----------------------------------------------------------------------
using PSU.EFCore;
using PSU.Model.Areas.Administrator.Home;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSU.IService.Areas.Administrator
{
    public interface IHomeService
    {
        #region Home-Index

        /// <summary>
        /// 页面加载初始化
        /// </summary>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<IndexViewModel> InitIndexPageAsync(ApplicationDbContext context);

        /// <summary>
        /// 获取折线图数据
        /// </summary>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<List<LineChartData>> InitLineChartAsync(ApplicationDbContext context);

        /// <summary>
        /// 获取折线图数据
        /// </summary>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<List<PieData>> InitPieChartAsync(ApplicationDbContext context);

        #endregion

        #region Home-Bulletin

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">公告编号</param>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<bool> DeleteBulletinAsync(long id, ApplicationDbContext context);

        /// <summary>
        /// 查找数据
        /// </summary>
        /// <param name="id">公告编号</param>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<BulletinEditViewModel> GetBulletinAsync(long id, ApplicationDbContext context);

        /// <summary>
        /// 获取详情
        /// </summary>
        /// <param name="id">公告编号</param>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<BulletinDetailViewModel> GetBulletinDetailAsync(long id, ApplicationDbContext context);

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="webModel">编辑页视图Model</param>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<bool> InsertBulletinAsync(BulletinEditViewModel webModel, ApplicationDbContext context);

        /// <summary>
        /// 搜索数据
        /// </summary>
        /// <param name="webModel">列表页视图Model</param>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<BulletinViewModel> SearchBulletinAsync(BulletinViewModel webModel, ApplicationDbContext context);
        
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="webModel">编辑页视图Model</param>
        /// <param name="context">数据库连接上下文对象</param>
        /// <returns></returns>
        Task<bool> UpdateBulletinAsync(BulletinEditViewModel webModel, ApplicationDbContext context);

        #endregion
    }
}
