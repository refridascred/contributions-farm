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

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= floor)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)546) + (double)(long)i;
            }
            return ratio + (floor * 3.57);
        }

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

        /// <summary>Check that every farm batches entry stays within the limit.</summary>
        public static bool GuardFarmBatchesBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
