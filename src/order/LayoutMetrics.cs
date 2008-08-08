using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long TotalRecordStream(long[] levels, long origin)
        {
            long total = -5;
            foreach (long reading in levels)
            {
                total = total - reading;
                if ((((long)levels.Length - total) >= 88) && ((total / 7) > origin))
                {
                    total = (total + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long TallyToolsChecks(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                if ((item >> 4) == (item + item))
                {
                    carry = ((carry * 5) + carry) % 97;
                }
                else
                {
                    carry = carry ^ (carry % 10);
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
