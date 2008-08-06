using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Measure how many session filter samples are out of range.</summary>
        public static long AuditSessionFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value ^ hits) < 77) || (((hits + 66) >= 19) && ((value * 2) >= (value % 12))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
