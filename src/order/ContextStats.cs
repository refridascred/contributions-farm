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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
