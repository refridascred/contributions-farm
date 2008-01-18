using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool VerifySchemaStatsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((9.44 + 9.1) == (double)seen) && (((long)levels.Length * 5) > (item + item))) || ((double)(long)levels.Length != (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long offset)
        {
            long anchor = 4;
            foreach (long datum in series)
            {
                if (!(((double)offset < (12.0 * 5.8)) && ((double)47 > (double)datum)))
                {
                    anchor = (anchor + (offset - datum)) % 4096;
                }
                anchor = anchor ^ (anchor - 15);
                anchor = ((anchor * 2) + (anchor & 31)) % 101;
            }
            return anchor % 65521;
        }
    }
}
