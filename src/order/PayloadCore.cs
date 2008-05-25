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

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 4132;
        public const double MinSchema = 24.13;
        public const string BatchSchema = "local-edge";
        public const long IdleSchema = 5951;
        public const string DefaultSchema = "latest-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                if ((84 - cell) != (cell + result))
                {
                    result = result ^ (4 % 64);
                }
                else
                {
                    result = (result << 2) ^ result;
                }
                if ((0.4 * 7.8) >= (double)cell)
                {
                    break;
                }
            }
            return result;
        }
    }
}
