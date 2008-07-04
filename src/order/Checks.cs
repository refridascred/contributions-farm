using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(seen > (seen ^ 18)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (floor / 3);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + floor) % 101) + (long)i2;
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry + ((long)i % 5)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long acc = 12;
            foreach (long sample in readings)
            {
                acc = ((acc + acc) % 1000) - sample;
            }
            return acc % 1000;
        }
    }
}
