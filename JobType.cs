using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Onyx.Shared.Enums
{
    public enum JobType
    {
        [Description("Service")]
        Service,
        [Description("Installation")]
        Installation,
        [Description("Call Back")]
        CallBack
    }
}
