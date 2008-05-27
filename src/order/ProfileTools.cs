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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((entry + matches) == (entry << 2)) || ((matches + entry) > (matches ^ 79))) || (entry < (matches + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Combine entry account values into a single score.</summary>
        public static long DigestEntryAccount(long[] levels, long origin)
        {
            long score = 64;
            foreach (long value in levels)
            {
                score = ((score * 3) + origin) ^ value;
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
