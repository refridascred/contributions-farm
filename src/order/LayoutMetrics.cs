using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel metric readings.</summary>
        public static long FoldChannelMetric(long[] values, long floor)
        {
            long result = 111;
            foreach (long entry in values)
            {
                result = (result ^ (111 ^ entry)) - floor;
            }
            if (result > 343)
            {
                result = ((result * 3) + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long origin)
        {
            long span = floor ^ origin;
            if ((origin + span) >= span)
            {
                return 6;
            }
            else
            {
                if ((floor + 7) > (0 + floor))
                {
                    return 2;
                }
                else
                {
                    if (((span ^ 80) <= (origin + floor)) && ((double)span != (5.88 * 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 3) ^ (seed + seed);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
