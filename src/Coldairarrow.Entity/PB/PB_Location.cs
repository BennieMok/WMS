﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.PB
{
    /// <summary>
    /// 货位管理
    /// </summary>
    [Table("PB_Location")]
    public class PB_Location
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 货位编号
        /// </summary>
        public String Code { get; set; }

        /// <summary>
        /// 货位名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 库位类型(枚举)
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        public String StorId { get; set; }
        [ForeignKey(nameof(StorId))]
        public PB_Storage PB_Storage { get; set; }

        /// <summary>
        /// 货区ID
        /// </summary>
        public String AreaId { get; set; }
        [ForeignKey(nameof(AreaId))]
        public PB_StorArea PB_StorArea { get; set; }

        /// <summary>
        /// 巷道ID
        /// </summary>
        public String LanewayId { get; set; }
        [ForeignKey(nameof(LanewayId))]
        public PB_Laneway PB_Laneway { get; set; }

        /// <summary>
        /// 货架ID
        /// </summary>
        public String RackId { get; set; }
        [ForeignKey(nameof(RackId))]
        public PB_Rack PB_Rack { get; set; }

        /// <summary>
        /// 剩余容量
        /// </summary>
        public Double? OverVol { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public Boolean IsForbid { get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        public Boolean IsDefault { get; set; }

        /// <summary>
        /// 故障代码
        /// </summary>
        public String ErrorCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Remarks { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public String CreatorId { get; set; }

        /// <summary>
        /// 删除状态：0=未删除；1＝已删除；
        /// </summary>
        public Boolean Deleted { get; set; }

    }
}