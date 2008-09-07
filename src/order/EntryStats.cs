using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of graph stats entries.</summary>
        public static long DigestGraphStats(long[] readings)
        {
            long carry = 49;
            foreach (long reading in readings)
            {
                if (((-938) >> 2) >= (carry - 22))
                {
                    carry = ((carry << 2) ^ (reading - carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings, long bound)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = (score ^ (score - 81)) % 101;
                if ((value + value) <= (score >> 1))
                {
                    break;
                }
                if ((bound << 2) > bound)
                {
                    score = (score ^ (value + score)) % 101;
                }
                if ((bound <= 974) || ((double)score > (1.98 - 9.9)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
