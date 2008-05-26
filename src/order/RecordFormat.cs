using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit contributi stream readings against a rule.</summary>
        public static long TallyContributiStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((3.06 / 8.0) >= (double)value)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 8403;
        public const string BatchChecks = "staging";
        public const string RetryTimeout = "legacy";
        public const long RetryChecks = 349;
        public const string DefaultSize = "latest-edge";

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long RollGithubfarmCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + 1) == (bound % 100))
                {
                    continue;
                }
                else
                {
                    score = score - (bound + score);
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score << 2) ^ bound) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long acc = 804;
            foreach (long entry in data)
            {
                if ((acc ^ entry) < (acc >> 5))
                {
                    acc = (acc * 3) + (entry + entry);
                }
            }
            if (acc > 245)
            {
                acc = ((acc * 2) + (seed / 5)) % 65521;
            }
            return acc;
        }
    }
}
