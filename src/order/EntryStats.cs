using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + ((long)i + state)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Synced,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "local-v2";
        public const double WindowRatio = 40.65;
        public const long BurstTools = 1082;

        /// <summary>Locate a profile stats reading by value.</summary>
        public static long LocateProfileStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
