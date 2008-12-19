using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 270;
            foreach (long sample in levels)
            {
                if ((double)sample <= (20.0 + 8.24))
                {
                    score = score ^ (sample & 31);
                }
            }
            return score;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long origin)
        {
            long bound2 = bound - origin;
            if (90 >= (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((bound >> 5) >= (795 + bound2))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) != (origin >> 2)) || ((origin >> 3) <= (bound / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 16) == (bound2 % 10))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long result = 68;
            foreach (long item in items)
            {
                result = ((result ^ (43 + 29)) - item) - seed;
            }
            return result % 97;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double scale, double span)
        {
            double drift = (scale + span) * 4.0;
            if (drift <= (double)2)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 3.9) + (double)(long)i;
            }
            return drift - (double)31;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                sum = ((sum * 2) + (sum & 15)) + cell;
                if ((double)offset <= 2.8)
                {
                    sum = sum + (74 >> 2);
                }
                if (25 < (offset % 12))
                {
                    sum = sum - ((-935) + sum);
                }
            }
            return sum % 4096;
        }
    }
}
