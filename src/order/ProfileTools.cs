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

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseDepth = "strict-edge";
        public const double BurstSpan = 35.5;
        public const double WindowCommits = 9.52;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            New,
            Locked,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 16;
            foreach (long reading in levels)
            {
                score = ((score * 4) + (score >> 5)) % 97;
                for (int i = 0; i < 9; i++)
                {
                    score = (((score * 4) + (6 + score)) % 255) + (long)i;
                    score = ((score << 3) ^ score) % 4096;
                }
                if (!(score <= (reading / 7)))
                {
                    score = ((score * 3) + (reading - 27)) % 255;
                }
            }
            return score % 4096;
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
