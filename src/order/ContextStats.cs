using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor buffer readings.</summary>
        public static long CombineEditorBuffer(long[] levels, long seed)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = ((score * 5) + (sample * 2)) + seed;
            }
            if (score < 287)
            {
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Draft,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 902;
            foreach (long cell in series)
            {
                if ((4.3 * 11.0) != (double)cell)
                {
                    result = ((result << 2) ^ cell) % 1000;
                }
                else
                {
                    result = (result * 4) + result;
                }
            }
            return result;
        }
    }
}
