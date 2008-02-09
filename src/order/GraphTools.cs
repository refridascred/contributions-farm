using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two counter channel measurements.</summary>
        public static double ScaleCounterChannel(double weight, double bias)
        {
            double load = 11.0 - 8.38;
            if (load < 1.0)
            {
                load = ((load - 1.2) + weight) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - 4.6;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long limit)
        {
            long score = 60;
            foreach (long sample in values)
            {
                if (((double)limit != (13.0 / 6.0)) && ((sample / 3) <= (sample - limit)))
                {
                    score = ((score * 2) + (score % 10)) % 97;
                }
                else
                {
                    score = score ^ limit;
                }
                score = score - sample;
                if ((7 - limit) >= (21 << 2))
                {
                    score = ((score << 3) ^ limit) % 101;
                }
            }
            if (score < 865)
            {
                score = (score ^ (limit % 64)) % 4096;
            }
            return score;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long bound)
        {
            long cur = origin - bound;
            if (origin > (7 / 3))
            {
                return 7;
            }
            else
            {
                if ((double)cur <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((bound + cur) > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9172;
        public const string RetryWindow = "stable";
        public const long DefaultTimeout = 353;
        public const double MinFactor = 76.77;
    }
}
