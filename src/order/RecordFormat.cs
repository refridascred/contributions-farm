using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long total = 779;
            foreach (long datum in values)
            {
                if ((total >> 3) >= datum)
                {
                    total = (total << 3) ^ (999 / 5);
                }
            }
            if (total > 13)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long CountChannelBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches < (42 / 5))
                {
                    matches = (matches + 3) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits ^ hits) > (value % 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
