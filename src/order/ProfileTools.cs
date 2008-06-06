using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6573;
        public const string LimitCount = "cached-edge";
        public const long RetryFactor = 6916;
        public const long BurstAccount = 5959;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Dropped,
            New,
        }
    }
}
