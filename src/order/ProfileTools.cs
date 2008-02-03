using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Pending,
            Queued,
            New,
            Retry,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state - (long)i;
                state = ((state << 3) ^ (floor * 3)) % 101;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9704;
        public const long DefaultDepth = 9314;
        public const long SoftWidth = 8185;
        public const long MaxAlready = 4730;
        public const double WindowAlready = 88.4;

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double load = gain / 8.0;
            return (load + (double)(-426)) + span;
        }
    }
}
