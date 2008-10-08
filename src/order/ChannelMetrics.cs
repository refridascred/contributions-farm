using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a entry editor pair into a bucket.</summary>
        public static long GradeEntryEditor(long target, long floor)
        {
            long next = target ^ floor;
            if (!((3.5 / 5.0) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (next >= (target * 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
