using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = (double)(524 % 2);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - scale) - (double)(long)i) - rate) + floor;
            }
            return scale + (double)553;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
