using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats context counter forward.</summary>
        public static long IterateStatsContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                long span = mark + 108;
                mark = (mark + (84 - span)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Retry,
            Dropped,
            New,
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long FoldNotesRoute(long[] readings, long origin)
        {
            long acc = -35;
            foreach (long cell in readings)
            {
                acc = (((acc << 3) ^ (40 - origin)) % 4096) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Pending,
            Stale,
            Ready,
            Retry,
        }
    }
}
