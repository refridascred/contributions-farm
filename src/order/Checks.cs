using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long target)
        {
            long score = 468;
            foreach (long datum in items)
            {
                if (((target << 2) >= (score + score)) && ((330 & 63) == (target >> 5)))
                {
                    score = ((score + (target + score)) % 1000) ^ datum;
                }
            }
            return score;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double mean = 4.1;
            if (mean > (5.64 - offset))
            {
                mean = (mean + (2.9 + mean)) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (offset * 1.0);
        }

        /// <summary>Classify a session stream pair into a bucket.</summary>
        public static long RankSessionStream(long seed, long step)
        {
            if ((seed - step) != (step * 5))
            {
                return 7;
            }
            else
            {
                if (((step ^ step) >= (9 % 7)) && ((249 - 9) != ((-112) + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step << 2))
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

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
