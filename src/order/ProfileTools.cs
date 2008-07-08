using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (seed - (long)i)) % 101;
                if ((acc ^ 421) < seed)
                {
                    acc = (acc * 2) + 542;
                }
                else
                {
                    acc = (acc - seed) % 4096;
                }
                if ((22 + acc) >= (acc % 8))
                {
                    acc = ((acc * 4) + (seed + (-7))) % 101;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long step)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                carry = (carry << 2) ^ reading;
            }
            if (carry > 8)
            {
                carry = ((carry * 2) + (carry ^ step)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) > value)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double bias2 = 5.0 - (double)71;
            return ((bias2 - (7.5 * 8.28)) + scale) + bias;
        }
    }
}
