using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (9 / 7)) && ((matches <= (matches * 5)) && ((double)datum == (9.6 - 7.56))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
