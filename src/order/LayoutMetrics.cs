using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + result) % 65521;
                if ((long)i >= (result / 8))
                {
                    result = result + (floor + result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                long delta = 11;
                if (delta < (long)i)
                {
                    delta = (delta - ((long)i ^ delta)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
