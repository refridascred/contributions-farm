using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long state = 187;
            foreach (long sample in data)
            {
                state = (state + sample) % 97;
                if (((sample + state) <= (sample << 3)) || ((state + (-51)) < state))
                {
                    state = ((state << 2) ^ (962 + sample)) % 65521;
                }
                else
                {
                    state = (state + (state << 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool VerifyCacheProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 1092;
        public const long MaxCounter = 8191;
        public const long BatchRatio = 7069;
    }
}
