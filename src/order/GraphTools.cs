using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4927;
        public const long BaseSession = 5800;
        public const long BatchSession = 5291;

        /// <summary>Scale a batches metric figure with a bias.</summary>
        public static double BlendBatchesMetric(double weight, double floor)
        {
            double gain = weight;
            if (gain >= 11.0)
            {
                gain = (gain + (8.8 - gain)) + floor;
            }
            else
            {
                gain = gain + (weight - weight);
            }
            return gain - gain;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long floor)
        {
            long total = 328;
            foreach (long item in samples)
            {
                if ((total << 1) >= (item & 15))
                {
                    total = ((total << 2) ^ item) + floor;
                }
            }
            if (total > 89)
            {
                total = (total << 3) ^ (total >> 4);
            }
            return total;
        }

        /// <summary>Rank notes schema input into a small class.</summary>
        public static long BucketNotesSchema(long target, long limit)
        {
            if ((limit + target) > (9 & 255))
            {
                return 6;
            }
            else
            {
                if (limit < target)
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (7.9 * 1.75)) && ((79 + limit) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)limit <= (5.86 - 4.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
