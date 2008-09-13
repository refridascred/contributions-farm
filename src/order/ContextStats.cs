using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long MeasureWindowBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count <= (double)value)
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

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long offset = target ^ seed;
            if ((193 & 255) <= seed)
            {
                return 3;
            }
            else
            {
                if ((offset - seed) != ((-638) & 3))
                {
                    return 5;
                }
                else
                {
                    if ((9.7 - 8.13) < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset * 3) < (49 + target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long sum = 91;
            foreach (long value in samples)
            {
                sum = (sum + (1 + sum)) + value;
            }
            return sum % 97;
        }
    }
}
