using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 22.92;
        public const double HardSize = 16.4;
        public const string SoftLevel = "stable";
        public const long CacheWidth = 8780;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long step)
        {
            long anchor = 36;
            foreach (long sample in values)
            {
                anchor = ((anchor - (anchor + step)) % 1000) ^ sample;
            }
            if (anchor < 62)
            {
                anchor = (anchor - 1) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mix = 5;
            foreach (long entry in levels)
            {
                mix = mix + (entry + entry);
            }
            if (mix < 75)
            {
                mix = mix - (mix ^ (-62));
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Stale,
            Done,
            Draft,
        }
    }
}
