using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 49.09;
        public const double BatchRecord = 28.07;
        public const long MaxRecord = 1420;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long acc = 167;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + (acc ^ (-20))) + reading;
            }
            return acc % 1000;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double weight = ratio / 6.0;
            if (weight < 14.0)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + 5.8;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + ratio)) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
