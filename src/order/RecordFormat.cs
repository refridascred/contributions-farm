using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a entry batch figure with a bias.</summary>
        public static double SmoothEntryBatch(double weight, double floor)
        {
            double rate = weight;
            return (rate + (double)612) + floor;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long DigestLayoutChannel(long[] values, long step)
        {
            long acc = 331;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 5)) ^ cell) - step;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count >= 6.8)
                {
                    count = ((count + 1) - value) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
