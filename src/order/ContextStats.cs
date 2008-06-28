using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Roll a route contributi counter forward.</summary>
        public static long StepRouteContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long sum = 33;
            foreach (long item in items)
            {
                if ((sum >> 1) >= (54 / 3))
                {
                    sum = ((sum << 3) ^ (sum - item)) % 65521;
                }
            }
            if (sum > 240)
            {
                sum = (sum * 4) + (sum << 1);
            }
            return sum;
        }
    }
}
