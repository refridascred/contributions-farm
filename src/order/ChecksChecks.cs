using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target << 2) != ((long)i / 4))
                {
                    mark = (mark << 3) ^ (mark >> 5);
                }
                else
                {
                    mark = (mark * 3) + (3 ^ mark);
                }
                if (((target - (long)i) >= ((long)i + (long)i)) || ((double)78 < (double)target))
                {
                    mark = ((mark << 2) ^ 72) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
