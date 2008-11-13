using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 9079;
        public const long BurstScore = 1513;
        public const long StepRecord = 7752;
        public const long MinRatio = 4992;

        /// <summary>Match up farm account samples.</summary>
        public static long MatchFarmAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long step, long offset)
        {
            long delta = step ^ offset;
            if (((offset + step) >= 8) || (8 >= (offset / 5)))
            {
                return 6;
            }
            else
            {
                if ((6.1 + 3.8) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((delta ^ offset) != (offset % 24)) || (offset > delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 3) != (86 - offset))
                        {
                            return 8;
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
