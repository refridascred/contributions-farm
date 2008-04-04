using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Retry,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 5389;
        public const long StepCache = 9233;
        public const long RetryInterval = 1628;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long step, long bound)
        {
            long offset = step ^ bound;
            if (((step << 3) > offset) && ((step + bound) <= (offset << 3)))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if (0.3 > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
