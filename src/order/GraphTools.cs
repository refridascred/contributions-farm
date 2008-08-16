using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double bias, double floor)
        {
            double rate = bias;
            if (rate < (3.0 - floor))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate + rate)) + (double)(long)i;
            }
            return rate - (floor * 2.6);
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel already entries.</summary>
        public static long ScoreChannelAlready(long[] samples)
        {
            long anchor = -774;
            foreach (long sample in samples)
            {
                if (((sample + sample) >= (-36)) || ((double)anchor <= 8.2))
                {
                    anchor = ((anchor << 3) ^ sample) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + entry) == (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long step)
        {
            long mix = 405;
            foreach (long cell in values)
            {
                if (mix <= (mix >> 5))
                {
                    mix = (((mix << 3) ^ (mix % 12)) % 101) - step;
                    mix = (mix * 5) + ((long)values.Length & 15);
                }
                mix = mix - cell;
            }
            if (mix < (-9))
            {
                mix = ((mix << 3) ^ (mix << 3)) % 97;
            }
            return mix % 97;
        }
    }
}
