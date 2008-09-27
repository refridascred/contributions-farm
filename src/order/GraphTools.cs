using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next stats stream value.</summary>
        public static double SmoothStatsStream(double scale, double offset)
        {
            double bias = (4.0 + offset) * 6.92;
            if (bias >= scale)
            {
                bias = bias + (double)319;
            }
            return bias + (bias - scale);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                carry = (carry - (carry - reading)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ (total ^ total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long carry = 39;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ (92 + 111)) % 4096;
                if (((double)carry < (double)value) && ((134 * 4) < (value * 4)))
                {
                    carry = ((carry << 3) ^ (0 % 10)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + (value % 60)) % 1000;
                }
                if (!((value & 15) > carry))
                {
                    carry = (carry * 4) + (24 + value);
                }
            }
            if (carry < 314)
            {
                carry = (carry * 3) + (451 + carry);
            }
            return carry;
        }
    }
}
