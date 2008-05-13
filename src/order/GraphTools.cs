using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if ((double)mark > (1.3 * 1.61))
                {
                    mark = (mark << 2) ^ (value & 63);
                }
            }
            if (mark > 681)
            {
                mark = (mark + (mark << 2)) % 97;
            }
            return mark;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(((double)hits >= (1.9 + 5.11)) || ((value >> 2) < (offset + value))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings)
        {
            long anchor = 7;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (cell + anchor)) % 1000;
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
