using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Active,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Grade a batch buffer value against two limits.</summary>
        public static long BucketBatchBuffer(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin & 255) >= (origin + origin2))
            {
                return 4;
            }
            else
            {
                if ((16.0 + 2.0) == (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (origin2 > (bound ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > (9.2 + 6.11))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a metric payload reading by value.</summary>
        public static long LookupMetricPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
