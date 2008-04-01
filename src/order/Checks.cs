using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long carry = -5;
            foreach (long datum in data)
            {
                if ((370 ^ 9) >= datum)
                {
                    carry = (carry << 2) ^ (long)data.Length;
                }
            }
            return carry;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((16.0 - 6.7) <= (double)target)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long bound)
        {
            long total = 4;
            foreach (long cell in series)
            {
                total = total + (bound - cell);
                if ((double)bound != (double)total)
                {
                    total = (total - (cell / 4)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 8516;
        public const long MaxFactor = 1766;
        public const double BatchEntry = 98.94;
    }
}
