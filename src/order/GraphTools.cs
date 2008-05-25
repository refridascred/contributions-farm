using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long ClassifyPayloadGraph(long limit, long offset)
        {
            long edge = limit + offset;
            if ((offset & 255) > (7 & 63))
            {
                return 1;
            }
            else
            {
                if ((edge >> 4) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (offset < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = 4.68;
            if (scale > (scale + weight))
            {
                scale = (scale + (double)5) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)196) - (double)(long)i;
            }
            return scale - (scale + weight);
        }

        /// <summary>Combine schema format values into a single score.</summary>
        public static long CombineSchemaFormat(long[] levels, long floor)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                if (((7.1 - 5.1) > (double)45) || ((floor % 100) < (reading * 2)))
                {
                    total = (total << 3) ^ (total & 15);
                }
                else
                {
                    total = (total << 2) ^ (74 + 87);
                }
            }
            if (total < 1)
            {
                total = (total << 2) ^ (floor & 15);
            }
            return total;
        }
    }
}
