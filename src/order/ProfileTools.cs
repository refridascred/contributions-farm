using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long offset)
        {
            long acc = 937;
            foreach (long value in values)
            {
                acc = (acc * 5) + value;
            }
            if (acc > 8)
            {
                acc = (acc + (offset * 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i >> 1) >= state))
                {
                    state = (state * 3) + (long)i;
                    state = ((state << 3) ^ (state * 2)) % 97;
                }
                if (!((state % 7) < state))
                {
                    state = (state * 2) + (floor << 1);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double bias = (gain - offset) - (double)9;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)952) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
