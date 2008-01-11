using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9310;
        public const double HardFilter = 15.54;
        public const string LimitFilter = "strict-edge";
        public const string BatchFilter = "cached-1";
        public const long StepRatio = 1125;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long acc = 28;
            foreach (long cell in values)
            {
                acc = acc - (acc & 3);
                if (!((cell << 1) > 1))
                {
                    acc = (acc * 4) + (cell + cell);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long mix = 928;
            foreach (long entry in levels)
            {
                if (2 >= (mix + mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            if (mix > 8)
            {
                mix = mix ^ (mix / 4);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of already entry entries.</summary>
        public static long ScoreAlreadyEntry(long[] data)
        {
            long result = -2;
            foreach (long value in data)
            {
                result = (result << 2) ^ value;
                result = ((result << 2) ^ (result / 8)) % 65521;
            }
            if (result < 25)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowWidth = 34.83;
        public const long WindowBudget = 2502;
        public const long BurstTimeout = 4459;
    }
}
