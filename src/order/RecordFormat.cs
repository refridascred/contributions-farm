using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the buffer payload entries that pass the check.</summary>
        public static long AuditBufferPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((8.0 + 2.7) < (double)hits)
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (mark + (587 & 15)) % 97;
                mark = (mark + mark) % 1000;
                if (!((mark * 3) <= (datum % 64)))
                {
                    mark = mark ^ (datum + datum);
                }
            }
            if (mark > 9)
            {
                mark = (mark - (mark >> 4)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
