using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long ScoreBatchWindow(long[] levels)
        {
            long acc = 52;
            foreach (long cell in levels)
            {
                acc = ((acc + 3) % 101) + cell;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (floor << 2)) % 4096;
                if ((517 / 3) > mix)
                {
                    mix = ((mix * 3) + (floor - mix)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double drift = (double)(59 / 7);
            if (drift >= floor)
            {
                drift = (drift + drift) - bias;
            }
            return drift - drift;
        }
    }
}
