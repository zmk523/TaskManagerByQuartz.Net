//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quartz.Net_EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class QRTZ_TRIGGERS
    {
        public string SCHED_NAME { get; set; }
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public string JOB_NAME { get; set; }
        public string JOB_GROUP { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<long> NEXT_FIRE_TIME { get; set; }
        public Nullable<long> PREV_FIRE_TIME { get; set; }
        public Nullable<int> PRIORITY { get; set; }
        public string TRIGGER_STATE { get; set; }
        public string TRIGGER_TYPE { get; set; }
        public long START_TIME { get; set; }
        public Nullable<long> END_TIME { get; set; }
        public string CALENDAR_NAME { get; set; }
        public Nullable<int> MISFIRE_INSTR { get; set; }
        public byte[] JOB_DATA { get; set; }
    
        public virtual QRTZ_CRON_TRIGGERS QRTZ_CRON_TRIGGERS { get; set; }
        public virtual QRTZ_JOB_DETAILS QRTZ_JOB_DETAILS { get; set; }
        public virtual QRTZ_SIMPLE_TRIGGERS QRTZ_SIMPLE_TRIGGERS { get; set; }
        public virtual QRTZ_SIMPROP_TRIGGERS QRTZ_SIMPROP_TRIGGERS { get; set; }
    }
}
