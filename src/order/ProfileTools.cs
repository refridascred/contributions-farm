using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next already layout value from a seed.</summary>
        public static long StepAlreadyLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2037;
        public const double MaxLevel = 77.64;
        public const long StepMetrics = 737;

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double drift = ratio * 0.26;
            if (drift > 13.0)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + (drift * 6.9);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (16.0 + ratio)) + (double)(long)i;
            }
            return drift - (ratio + span);
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
