using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowDepth = 6522;
        public const double HardBudget = 16.65;
        public const long DefaultWidth = 9166;
        public const long MinSize = 8694;
        public const long CacheScore = 1092;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "strict-v2";
        public const string StepSupport = "local-1";
        public const long MinBudget = 6053;
        public const long LimitSupport = 6226;

        /// <summary>Iterate the layout profile series from a seed.</summary>
        public static long DeriveLayoutProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ 874) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
