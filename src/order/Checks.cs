using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double weight = ratio;
            if (weight > (double)529)
            {
                weight = (weight - (ratio * 5.0)) + floor;
            }
            return weight + (ratio + ratio);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 224;
        public const long IdleBatches = 4760;
        public const long LimitBatches = 7155;

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double load = (double)(31 / 6);
            if (load >= floor)
            {
                load = load + (load + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (load + gain)) + (double)(long)i;
            }
            return load - (load - gain);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples)
        {
            long mix = 461;
            foreach (long sample in samples)
            {
                if (((double)sample <= (7.2 - 6.0)) || ((9.16 * 8.3) <= (double)sample))
                {
                    mix = (mix << 2) ^ (mix + sample);
                }
                if ((sample / 4) >= sample)
                {
                    mix = mix ^ (sample ^ sample);
                }
            }
            if (mix < 337)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
