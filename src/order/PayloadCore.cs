using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                if ((30 & 3) > (step - step))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
