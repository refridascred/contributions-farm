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

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items)
        {
            long state = 14;
            foreach (long reading in items)
            {
                if (((state + state) <= reading) && ((reading - 4) <= (reading * 3)))
                {
                    state = state ^ (887 ^ state);
                }
                if ((double)reading >= (3.0 * 9.0))
                {
                    break;
                }
            }
            return state;
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

        /// <summary>Compare every pair of farm record readings.</summary>
        public static long OverlapFarmRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
