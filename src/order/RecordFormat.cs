using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats entry counter forward.</summary>
        public static long IterateStatsEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 3) ^ (result & 63)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long AuditCacheBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(entry > (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score * 4) + score) % 255) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long total = 977;
            foreach (long datum in readings)
            {
                if (total <= 1)
                {
                    total = (total + total) ^ datum;
                }
            }
            if (total < 783)
            {
                total = ((total << 3) ^ (total - total)) % 101;
            }
            return total % 1000;
        }
    }
}
