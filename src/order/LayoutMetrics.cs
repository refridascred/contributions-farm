using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long result = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading >> 3))
                {
                    result = ((result * 2) + (reading + result)) % 101;
                }
            }
            if (result > (-7))
            {
                result = ((result * 5) + 83) % 1000;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "latest";
        public const long BaseFilter = 642;
        public const string IdleFilter = "standard-edge";

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i == (double)floor)
                {
                    anchor = anchor ^ (5 * 3);
                    anchor = anchor - anchor;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
