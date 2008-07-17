using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = total + total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long score = 97;
            foreach (long reading in series)
            {
                if ((score - (-175)) >= (reading - reading))
                {
                    score = (score + reading) % 4096;
                    continue;
                }
                else
                {
                    score = score ^ (reading + reading);
                }
                if ((score & 31) <= (score - score))
                {
                    score = score - (score + 1);
                }
            }
            if (score < 7)
            {
                score = (score ^ (score ^ 9)) % 1000;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 81.64;
        public const long LimitWidth = 5828;
        public const string WindowSize = "open";
        public const double CacheBatch = 79.71;

        /// <summary>Look up the position of a token tools sample.</summary>
        public static long LocateTokenToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
