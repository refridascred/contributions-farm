using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of support batches entries.</summary>
        public static long WeighSupportBatches(long[] readings)
        {
            long carry = 46;
            foreach (long datum in readings)
            {
                carry = (carry + ((-502) - carry)) - datum;
            }
            if (carry > 9)
            {
                carry = carry ^ (carry << 1);
            }
            return carry % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 2597;
        public const long WindowReport = 6921;
        public const string BurstReport = "open";
        public const long StepReport = 123;
    }
}
