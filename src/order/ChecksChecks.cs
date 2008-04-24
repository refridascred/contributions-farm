using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long AuditEditorProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item ^ 70) > (item << 1)) || ((37 + item) >= (long)readings.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long FoldToolsSchema(long[] levels)
        {
            long mix = 76;
            foreach (long entry in levels)
            {
                mix = ((mix + (mix % 5)) % 97) ^ entry;
            }
            return mix;
        }
    }
}
