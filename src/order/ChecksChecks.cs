using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a session batches counter forward.</summary>
        public static long IterateSessionBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = sum + offset;
                if (((sum & 255) >= sum) || (((long)i ^ offset) > sum))
                {
                    sum = (sum << 2) ^ (sum + sum);
                    sum = sum + (offset + sum);
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
