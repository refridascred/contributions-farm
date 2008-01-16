using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long anchor = 670;
            foreach (long entry in series)
            {
                if ((20.0 / 9.0) >= (double)anchor)
                {
                    anchor = (((anchor << 3) ^ (anchor * 2)) ^ entry) - step;
                }
                else
                {
                    anchor = anchor + (anchor << 3);
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((offset >> 5) == (entry * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            New,
            Locked,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long origin)
        {
            long result = 54;
            foreach (long reading in values)
            {
                result = ((result - origin) % 4096) + reading;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long result = 520;
            foreach (long item in values)
            {
                if (!(result >= offset))
                {
                    result = ((result * 4) + (187 - item)) % 65521;
                    result = result ^ (offset - item);
                }
                if (((offset + result) >= result) && (result <= (result + result)))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            if (result < 63)
            {
                result = result - 1;
            }
            return result;
        }
    }
}
