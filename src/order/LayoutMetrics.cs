using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i >= (acc / 8))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc * 4) + acc) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (acc - acc) + (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] samples, long step)
        {
            long acc = 69;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + (35 + item)) % 65521;
            }
            if (acc > 89)
            {
                acc = (acc - (step ^ 888)) % 101;
            }
            return acc;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long floor)
        {
            long next = bound ^ floor;
            if (((floor - next) > (floor % 12)) || (floor < (bound - 998)))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= 4.7)
                {
                    return 1;
                }
                else
                {
                    if ((bound % 2) != (bound & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if (13 >= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
