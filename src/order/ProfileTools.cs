using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheLevel = 1964;
        public const long MinCommits = 3842;
        public const double BaseTimeout = 90.2;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings, long floor)
        {
            long sum = 160;
            foreach (long reading in readings)
            {
                sum = (((sum * 5) + floor) % 65521) ^ reading;
            }
            if (sum < 33)
            {
                sum = (sum * 5) + (floor + 640);
            }
            return sum % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 6985;
        public const long IdleStream = 1105;
        public const double CacheStream = 85.48;
        public const long WindowStream = 7146;
    }
}
