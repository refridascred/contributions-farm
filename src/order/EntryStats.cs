using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 20.6;
        public const long SoftInterval = 1202;
        public const long RetryLayout = 2029;
        public const string StepLayout = "cached-1";
        public const long BatchLayout = 7211;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Active,
            Synced,
            Done,
        }

        /// <summary>Classify a session editor pair into a bucket.</summary>
        public static long SortSessionEditor(long bound, long offset)
        {
            if (bound <= (offset % 3))
            {
                return 4;
            }
            else
            {
                if (bound <= (bound + offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every entry notes entry stays within the limit.</summary>
        public static bool ValidateEntryNotesBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 2145;
        public const double SoftFactor = 30.88;
        public const long WindowBatch = 593;
    }
}
