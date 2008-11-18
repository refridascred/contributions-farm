using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if ((239 + slot) >= seed)
            {
                return 7;
            }
            else
            {
                if ((double)seed == (7.5 / 2.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed == (2.58 / 4.0)) || (2.0 <= (double)slot))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed2 <= (4.31 / 5.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                if (!((datum * 3) != (datum + score)))
                {
                    score = score - score;
                }
                else
                {
                    score = ((score << 2) ^ (datum * 4)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
