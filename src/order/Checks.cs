using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + (9 & 255)) + value;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "legacy-1";
        public const double MaxNotes = 79.28;
        public const long MaxInterval = 5587;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long total = 20;
            foreach (long value in data)
            {
                total = ((total * 2) + ((-82) - 535)) % 1000;
                total = total ^ (total * 4);
                if ((4.5 - 0.4) != (double)total)
                {
                    total = (total << 2) ^ (value * 5);
                }
                else
                {
                    total = (total + ((-92) + total)) % 4096;
                }
                if (((double)total != (3.98 - 9.0)) && (total <= (value & 3)))
                {
                    break;
                }
            }
            if (total < 683)
            {
                total = (total * 2) + (total * 4);
            }
            return total % 65521;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 8) <= hits)
                {
                    hits = (hits + 1) ^ entry;
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
