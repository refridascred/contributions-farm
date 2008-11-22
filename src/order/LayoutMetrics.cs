using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor support entries.</summary>
        public static long FoldEditorSupport(long[] levels, long seed)
        {
            long sum = 24;
            foreach (long datum in levels)
            {
                if ((datum << 1) > sum)
                {
                    sum = sum - seed;
                }
                else
                {
                    sum = sum + seed;
                }
                if (seed > (seed ^ datum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool ValidateTokenQueueRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
