using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long bound)
        {
            long acc = 11;
            foreach (long value in data)
            {
                acc = ((acc << 2) ^ (acc * 3)) ^ value;
                acc = acc + bound;
            }
            if (acc < 3)
            {
                acc = (acc + (41 / 4)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long state = 808;
            foreach (long datum in data)
            {
                state = state + datum;
            }
            return state;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (bias * 2.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 26.05;
        public const long DefaultFactor = 1382;
        public const long RetryFarm = 8110;
        public const long DefaultFarm = 9458;
        public const long RetryBudget = 5151;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long sum = 940;
            foreach (long reading in readings)
            {
                sum = (sum - (reading + reading)) % 1000;
                if (((double)sum == (6.58 * 7.4)) || ((reading + reading) >= (reading ^ 794)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
