using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a format account reading by value.</summary>
        public static long FindFormatAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitBudget = "alpha";
        public const long MaxInterval = 2952;
        public const long StepCount = 5449;
        public const long HardFormat = 3573;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((((mix * 3) + 62) % 65521) ^ (long)i) + entry;
                }
                mix = (mix ^ (bound % 100)) % 101;
                mix = mix + 5;
            }
            return mix % 97;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double weight = bias / 4.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 7.92) + (double)(long)i;
            }
            return weight + (floor / 4.0);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
