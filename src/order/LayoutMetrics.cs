using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long seed, long floor)
        {
            if ((seed ^ seed) >= (seed << 3))
            {
                return 1;
            }
            else
            {
                if (((seed + floor) != (floor - seed)) && ((double)seed > 20.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor - seed) <= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed < (19.0 * 15.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - limit) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
