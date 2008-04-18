using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long seed, long target)
        {
            if ((double)seed < (5.21 * 5.47))
            {
                return 2;
            }
            else
            {
                if (((double)target != (9.9 + 6.2)) && ((seed % 12) != (target << 3)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long target2)
        {
            if ((9.6 + 6.93) != (double)target2)
            {
                return 2;
            }
            else
            {
                if ((target2 + 2) >= target2)
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 <= (9.9 - 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value << 2) != (hits ^ hits)) || !((3 - value) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double mean = span;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - span) + (double)(long)i) - gain;
            }
            return mean + mean;
        }
    }
}
