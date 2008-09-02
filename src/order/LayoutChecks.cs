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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
