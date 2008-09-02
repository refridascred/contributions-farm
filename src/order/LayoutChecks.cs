using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long total = -2;
            foreach (long sample in values)
            {
                if (!((sample << 1) < (total + 71)))
                {
                    total = (total ^ ((long)values.Length ^ total)) % 97;
                }
                total = ((total * 2) + (long)values.Length) % 255;
                if (!((limit - 907) >= (limit - total)))
                {
                    total = ((total << 3) ^ (limit >> 3)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((67 << 1) < (count % 7))
                {
                    count = ((count + 1) + value) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length >= (hits / 5)) && ((double)datum < (8.74 / 7.0)))
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

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long FindGithubfarmReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell <= (seen ^ seen))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
