using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((double)matches < (7.37 * 3.91)) && (5.66 < (double)datum))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long mark = 6;
            foreach (long reading in data)
            {
                if (!(mark < (reading - mark)))
                {
                    mark = (mark << 3) ^ (-419);
                }
                else
                {
                    mark = mark + (reading * 4);
                }
            }
            if (mark > 500)
            {
                mark = ((mark * 3) + (1 >> 5)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen <= (9.4 * 8.7))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
