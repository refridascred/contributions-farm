using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= (span / 9.0))
            {
                weight2 = weight2 - weight;
            }
            return weight2 - (span + 1.51);
        }

        /// <summary>Project the next graph context value.</summary>
        public static double ProjectGraphContext(double scale, double span)
        {
            double ratio = (double)(0 + 3);
            if (ratio > span)
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 9.29) - (double)(long)i;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Digest a series of notes command entries.</summary>
        public static long DigestNotesCommand(long[] values)
        {
            long acc = 5;
            foreach (long item in values)
            {
                if (acc <= ((-534) + acc))
                {
                    acc = (((acc << 3) ^ acc) % 255) - item;
                }
                else
                {
                    acc = (acc + (acc >> 4)) % 97;
                }
                if ((3.95 + 20.0) != (double)acc)
                {
                    break;
                }
            }
            if (acc > 730)
            {
                acc = acc - (acc * 3);
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchCount = 7292;
        public const long LimitAlready = 3280;
        public const long MinAlready = 7242;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Pending,
            Idle,
        }
    }
}
