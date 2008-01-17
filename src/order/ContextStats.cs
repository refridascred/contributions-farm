using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (413 + value))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            long span = floor + bound;
            if (727 >= span)
            {
                return 4;
            }
            else
            {
                if (((1.36 - 5.6) >= (double)floor) && ((span % 8) >= (span - span)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a batches schema value against two limits.</summary>
        public static long GradeBatchesSchema(long limit, long offset)
        {
            if (limit > (limit << 2))
            {
                return 4;
            }
            else
            {
                if ((3.16 * 1.0) == (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset < (2.46 * 14.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((97 * 2) < (offset % 97))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double ProjectContextBatch(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight - span);
        }
    }
}
