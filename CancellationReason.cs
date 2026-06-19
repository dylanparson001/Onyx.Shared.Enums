using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Onyx.Shared.Enums
{
    public enum CancellationReason
    {
        [Description("Customer Cancelled")]
        CustomerCancelled,
        [Description("Rescheduled")]
        Rescheduled,

    }
}
