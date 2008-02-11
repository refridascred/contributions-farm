using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            if (!((floor / 2) != (floor >> 1)))
            {
                return 1;
            }
            else
            {
                if (bound >= (5 * 4))
                {
                    return 0;
                }
                else
                {
                    if (((782 + 8) >= (bound + floor)) || (3 > floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((709 ^ bound) >= (bound - 2)) && ((bound ^ bound) <= floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(((double)value >= (19.0 - 8.16)) && ((double)count <= (4.5 - 7.05))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
