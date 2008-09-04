using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long offset)
        {
            long total = 19;
            foreach (long cell in series)
            {
                if (4.0 <= (double)cell)
                {
                    total = ((total + cell) % 101) - offset;
                }
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long anchor = 40;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ item) % 4096;
                anchor = anchor + (item / 8);
                anchor = (anchor - 524) % 97;
            }
            if (anchor > (-30))
            {
                anchor = anchor - anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }
    }
}
