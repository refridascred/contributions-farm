using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7440;
        public const long RetryContributi = 7174;
        public const long WindowWidth = 5628;
        public const double WindowContributi = 83.9;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long target, long origin)
        {
            if ((origin / 4) <= (target + target))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (origin ^ 43))
                {
                    return 4;
                }
                else
                {
                    if ((50 >= (origin + origin)) && (24 > (origin ^ 601)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + origin) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the account layout series from a seed.</summary>
        public static long DeriveAccountLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ (origin - score)) % 255;
                score = (score + (origin ^ origin)) % 1000;
                score = ((score * 4) + (97 & 3)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine report buffer values into a single score.</summary>
        public static long WeighReportBuffer(long[] series)
        {
            long mix = 74;
            foreach (long cell in series)
            {
                mix = ((mix ^ (mix << 2)) % 65521) ^ cell;
            }
            return mix % 97;
        }
    }
}
