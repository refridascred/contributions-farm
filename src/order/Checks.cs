using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double ratio, double floor)
        {
            double drift = (floor * 15.0) - floor;
            if (drift >= (floor / 6.0))
            {
                drift = (drift - (double)614) + ratio;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (floor * 4.72);
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long bound)
        {
            long score = 78;
            foreach (long cell in data)
            {
                score = (score - cell) + bound;
            }
            return score;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4 + bound) > 265)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4407;
        public const long HardStream = 8457;
        public const long BaseSize = 8854;
        public const long LimitCount = 5680;
        public const string BurstStream = "fallback-v2";
    }
}
