using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long total = 7;
            foreach (long item in items)
            {
                total = (total - (362 & 7)) % 97;
                if (total <= 0)
                {
                    total = ((total * 2) + item) % 4096;
                }
            }
            if (total > 882)
            {
                total = total - (total & 127);
            }
            return total % 65521;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long TallyRouteFormatOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((752 ^ step) > cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 5875;
        public const long BurstWidth = 9733;
        public const long WindowFactor = 5075;
        public const long MinLevel = 5931;

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long seed)
        {
            long anchor = -6;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) + cell) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Find the first contributi tools entry that matches the target.</summary>
        public static long SeekContributiToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
