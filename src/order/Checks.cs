using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) == (sample + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long FindOrderStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long total = -54;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ (total + total)) - (long)i;
                    total = ((total * 2) + (total << 1)) % 65521;
                }
                total = (total ^ (total << 2)) % 1000;
                if (((404 >> 2) <= (total + total)) && (total > (total + 9)))
                {
                    total = total - item;
                }
                else
                {
                    total = ((total * 2) + (item << 2)) % 101;
                }
            }
            if (total > 73)
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
