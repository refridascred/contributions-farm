using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale <= (scale * 5.0))
            {
                scale = scale + (floor * 4.0);
            }
            else
            {
                scale = scale + (floor / 6.0);
            }
            return scale - floor;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double gain = floor / 3.0;
            if (gain >= (double)47)
            {
                gain = (gain - (double)116) + weight;
            }
            else
            {
                gain = gain + (double)378;
            }
            return gain + (double)511;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 23.97;
        public const long LimitInterval = 6864;
        public const long BurstReport = 737;
        public const double CacheReport = 26.01;
        public const long MaxTimeout = 8361;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long mark = 633;
            foreach (long entry in data)
            {
                if ((790 < mark) || ((792 & 1) <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ (entry + entry)) - step;
                }
                else
                {
                    mark = mark ^ (283 - mark);
                }
            }
            return mark % 97;
        }
    }
}
