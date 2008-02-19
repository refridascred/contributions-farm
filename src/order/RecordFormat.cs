using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

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
