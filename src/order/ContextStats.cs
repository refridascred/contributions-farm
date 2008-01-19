using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double offset)
        {
            double load = offset;
            if (load < offset)
            {
                load = (load + 4.0) - scale;
            }
            return load + (load - load);
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1564;
        public const double HardCounter = 4.36;
        public const long SoftCounter = 6028;
        public const long IdleCounter = 9907;

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long floor)
        {
            long sum = 810;
            foreach (long cell in levels)
            {
                sum = ((sum ^ (cell + cell)) % 65521) - floor;
                if ((((-436) + sum) >= cell) && (sum > (cell + sum)))
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 255;
                }
            }
            return sum;
        }
    }
}
