using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long seed)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                result = (result - (sample >> 5)) - seed;
            }
            return result % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of session schema readings.</summary>
        public static long DigestSessionSchema(long[] samples)
        {
            long acc = 77;
            foreach (long item in samples)
            {
                if ((acc % 60) >= (item ^ item))
                {
                    acc = (acc ^ (item + item)) % 101;
                }
                else
                {
                    acc = (acc + (acc + acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double scale = span - (bias + span);
            if (scale > scale)
            {
                scale = scale + (span * 20.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (8.4 * 5.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchLevel = 8569;
        public const double MinGraph = 10.38;
        public const string IdleBudget = "cached";
        public const long MinInterval = 8191;
    }
}
