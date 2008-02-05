using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double mean = span - span;
            if (mean <= gain)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean / 5.0)) - (double)(long)i;
            }
            return mean - (mean + gain);
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long bound)
        {
            if (((6.6 / 4.0) == (double)bound) && ((bound * 3) != (bound - step)))
            {
                return 1;
            }
            else
            {
                if ((step % 10) < bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long seed)
        {
            if ((seed > (seed + seed)) || ((seed & 1) == (634 >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit >= seed) && ((limit ^ limit) >= (limit - 593)))
                {
                    return 8;
                }
                else
                {
                    if (((limit >> 5) >= (limit + limit)) && ((limit - 96) < (seed / 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + 4) != (seed + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Retry,
            Synced,
            Failed,
        }
    }
}
