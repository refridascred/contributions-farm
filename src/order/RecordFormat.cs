using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double weight = (double)8 + (offset / 7.0);
            if (weight > (scale / 4.0))
            {
                weight = weight - (scale - offset);
            }
            return weight + scale;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                if (391 <= (result + (long)i))
                {
                    result = (result + (result + result)) % 65521;
                }
                if (((long)i * 3) == (origin % 2))
                {
                    result = result - (result ^ origin);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ step) <= (step & 1))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (90 * 4)) + (long)i2;
                    anchor = anchor ^ (65 / 7);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series, long origin)
        {
            long carry = 464;
            foreach (long value in series)
            {
                carry = (carry - origin) ^ value;
                carry = carry - (30 * 4);
                if ((double)carry <= 0.4)
                {
                    carry = ((carry * 2) + (carry / 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
