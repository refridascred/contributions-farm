using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long seed)
        {
            long step2 = step ^ seed;
            if (!((step2 % 2) == (47 >> 3)))
            {
                return 5;
            }
            else
            {
                if ((step2 - step) != (seed ^ 0))
                {
                    return 6;
                }
                else
                {
                    if ((step2 ^ step2) < (83 % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Locate a schema commits reading by value.</summary>
        public static long LocateSchemaCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch support pair into a bucket.</summary>
        public static long BucketBatchSupport(long bound, long limit)
        {
            if (((bound & 127) < (bound - bound)) && ((2.67 * 0.9) < (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound > (bound - bound)) && ((bound + bound) <= (limit - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound > (limit ^ limit)) && ((limit % 12) < (limit % 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count profile metric pairs that satisfy a relation.</summary>
        public static long MatchProfileMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
