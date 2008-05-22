using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "primary-edge";
        public const long MaxCount = 2329;
        public const double CacheRatio = 6.39;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (bound & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool GuardFormatSessionRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] data)
        {
            long state = 39;
            foreach (long reading in data)
            {
                if (reading <= (state - reading))
                {
                    state = (state * 3) + reading;
                }
            }
            return state;
        }
    }
}
