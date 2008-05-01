using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double ratio = (double)(295 << 1);
            if (ratio > (ratio - ratio))
            {
                ratio = ((ratio + 2.0) - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (5.5 / 2.0)) + (double)(long)i;
            }
            return ratio + ratio;
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
