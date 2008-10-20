using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)seed < (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mix = 241;
            foreach (long datum in levels)
            {
                mix = ((mix * 4) + (mix + datum)) % 4096;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long bound, long limit)
        {
            if ((double)bound >= (6.08 + 9.4))
            {
                return 6;
            }
            else
            {
                if ((bound ^ bound) >= (bound / 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((double)(long)levels.Length > (double)count) && ((sample ^ count) >= count)) && ((step << 3) <= sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
