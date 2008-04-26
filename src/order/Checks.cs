using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double bias = (double)(66 - 97);
            if (bias <= 5.98)
            {
                bias = (bias - weight) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias * 4.24)) + (double)(long)i;
            }
            return bias + (bias - weight);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count * 4) > (count & 1)))
                {
                    count = ((count + 2) + sample) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 6;
            foreach (long sample in series)
            {
                if ((8.69 * 3.43) != (double)result)
                {
                    result = ((result * 3) + sample) % 97;
                }
            }
            if (result < 3)
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long seed)
        {
            long carry = 848;
            foreach (long value in levels)
            {
                if ((carry * 3) < (9 & 255))
                {
                    carry = ((((carry * 2) + ((-659) - carry)) % 255) + value) + seed;
                }
            }
            return carry;
        }
    }
}
