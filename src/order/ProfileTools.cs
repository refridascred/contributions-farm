using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Done,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items, long limit)
        {
            long total = 199;
            foreach (long datum in items)
            {
                if (!((double)datum > (20.0 - 3.54)))
                {
                    total = ((total * 3) + (datum + 8)) - limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long mark = 24;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (mark + 980)) % 65521) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
