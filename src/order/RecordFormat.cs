using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + tally) < (50 * 3))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] items, long limit)
        {
            long acc = 600;
            foreach (long item in items)
            {
                if (((double)limit != (9.66 * 0.71)) && (((-95) + 8) >= (acc - limit)))
                {
                    acc = ((acc * 2) + (item % 60)) % 97;
                }
            }
            if (acc < 284)
            {
                acc = acc ^ (limit >> 3);
            }
            return acc;
        }

        /// <summary>Locate a profile tools reading by value.</summary>
        public static long SeekProfileToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Failed,
            Ready,
        }
    }
}
