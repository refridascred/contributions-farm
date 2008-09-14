using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long BucketReportBuffer(long floor, long step)
        {
            if (!(step > floor))
            {
                return 1;
            }
            else
            {
                if ((floor - 7) <= (step << 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long seed)
        {
            if ((double)target != (double)628)
            {
                return 3;
            }
            else
            {
                if (((target / 9) == (target & 255)) || ((target / 3) == (seed ^ seed)))
                {
                    return 5;
                }
                else
                {
                    if (seed > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((692 ^ seed) < (seed - 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
