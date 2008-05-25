using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long step)
        {
            long prev = floor + step;
            if ((double)prev >= 7.0)
            {
                return 7;
            }
            else
            {
                if ((floor - floor) > (657 + floor))
                {
                    return 8;
                }
                else
                {
                    if (!(floor > (prev % 60)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev & 127) > (floor >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Ready,
            Failed,
        }
    }
}
