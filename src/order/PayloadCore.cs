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

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long FoldChannelStats(long[] readings)
        {
            long acc = 40;
            foreach (long datum in readings)
            {
                acc = (acc + (datum / 8)) % 65521;
            }
            return acc;
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
