using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long carry = 876;
            foreach (long value in series)
            {
                if (((double)carry <= (9.15 / 2.0)) || ((carry % 7) >= (value + value)))
                {
                    carry = (carry * 4) + (carry << 1);
                }
                else
                {
                    carry = (carry + (carry - value)) % 97;
                }
            }
            if (carry > 80)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long SeriesClusterFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 260;
        public const double LimitStats = 18.84;
        public const long StepCount = 2997;
    }
}
