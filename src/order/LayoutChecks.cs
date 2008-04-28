using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Idle,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Paused,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((2.0 - 7.2) == (double)hits)
                {
                    hits = ((hits + 2) + cell) - floor;
                }
            }
            return hits;
        }
    }
}
