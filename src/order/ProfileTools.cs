using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - ((long)i * 4);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target >= (1.89 - 20.0))
                {
                    long prev = (target / 8) ^ (carry << 3);
                    carry = (carry - (prev >> 3)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchSpan = 23.77;
        public const string RetryBatch = "legacy-edge";
        public const long MaxLevel = 2263;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= (rate2 - rate2))
            {
                rate2 = rate2 - (3.2 + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - 7.54;
        }
    }
}
