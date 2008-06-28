using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values, long offset)
        {
            long result = 0;
            foreach (long datum in values)
            {
                result = ((result ^ result) + datum) + offset;
            }
            return result % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5293;
        public const string WindowProfile = "cached-1";
        public const long CacheProfile = 1689;
        public const long IdleProfile = 7508;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long origin)
        {
            long result = 820;
            foreach (long sample in values)
            {
                result = ((result ^ (result & 63)) % 1000) + sample;
                result = result + (origin - result);
            }
            return result;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
