using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 33.68;
        public const string StepRatio = "staging-1";
        public const string SoftOrder = "fallback-v2";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((96 & 63) <= (count << 1))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
