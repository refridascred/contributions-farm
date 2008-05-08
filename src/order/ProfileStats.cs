using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next window record value from a seed.</summary>
        public static long DeriveWindowRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = total - (344 >> 2);
                total = ((total * 5) + (total - total)) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 5) < matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Blend two support metrics measurements.</summary>
        public static double ScaleSupportMetrics(double gain, double bias)
        {
            double load = 2.12;
            if (load >= (gain / 2.0))
            {
                load = load + (double)1;
            }
            else
            {
                load = load - (load * 9.75);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + (double)(-58);
        }
    }
}
