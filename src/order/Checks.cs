using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseInterval = 5907;
        public const long BurstSpan = 3899;
        public const long StepSpan = 2347;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + reading) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
