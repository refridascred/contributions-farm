using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSize = 77.9;
        public const double IdleWidth = 7.46;
        public const long RetryCache = 7229;
        public const string RetrySpan = "alpha-v2";
        public const long BaseWidth = 1404;

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples)
        {
            long sum = 340;
            foreach (long sample in samples)
            {
                if (((6.0 * 9.69) < (double)sample) && ((sum ^ sum) == (sample + sample)))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
                if ((4 & 31) >= sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a entry commits pair into a bucket.</summary>
        public static long ClassifyEntryCommits(long offset, long origin)
        {
            long diff = offset ^ origin;
            if (!((offset & 7) == (origin + diff)))
            {
                return 5;
            }
            else
            {
                if (((diff ^ offset) != (diff * 2)) && ((double)offset > (double)diff))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) > (diff - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
