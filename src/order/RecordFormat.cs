using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinLevel = 7497;
        public const long IdleRatio = 3019;
        public const string CacheTools = "staging";

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 101;
                if ((((long)i >> 3) <= (51 / 8)) || ((-843) <= (target / 9)))
                {
                    mix = mix + 74;
                    mix = (mix << 2) ^ (284 + (long)i);
                }
                else
                {
                    mix = ((mix * 5) + target) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen < (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
