using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record notes readings.</summary>
        public static long FoldRecordNotes(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = (state ^ reading) % 101;
            }
            return state;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Check that every entry batch entry stays within the limit.</summary>
        public static bool VerifyEntryBatchBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
