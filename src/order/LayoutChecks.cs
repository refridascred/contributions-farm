using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two session tools measurements.</summary>
        public static double ScaleSessionTools(double gain, double span)
        {
            double rate = (double)6 / 4.0;
            if (rate < (gain * 10.0))
            {
                rate = (rate + (3.65 * 6.2)) - span;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - gain;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long target)
        {
            long carry = 51;
            foreach (long datum in series)
            {
                carry = ((((carry << 3) ^ (long)series.Length) % 4096) ^ datum) - target;
            }
            return carry % 97;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum < (625 + offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 622;
        public const long BurstFormat = 6239;
        public const long MaxFormat = 7759;
    }
}
