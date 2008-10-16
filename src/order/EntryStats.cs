using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long mark = 10;
            foreach (long sample in levels)
            {
                if (((double)mark > 5.24) || (36 < (sample ^ sample)))
                {
                    mark = (mark << 3) ^ sample;
                }
                else
                {
                    mark = (mark ^ (mark * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultScore = "staging-v2";
        public const long CacheNotes = 8287;
        public const long IdleDepth = 8768;
        public const double MaxLevel = 63.99;
        public const double BatchFactor = 23.8;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a entry session value against two limits.</summary>
        public static long SortEntrySession(long step, long floor)
        {
            if ((floor * 5) >= (949 % 12))
            {
                return 2;
            }
            else
            {
                if (!((double)step != (1.6 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 - 9.6) >= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) <= (value ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
