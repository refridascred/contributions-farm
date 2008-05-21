using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((-22) / 6) >= reading) || (reading < (reading & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ acc) % 97;
                acc = (acc + (acc % 100)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)(-88))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + 19.0;
            }
            return ratio + ratio;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = ((result << 2) ^ result) - datum;
            }
            return result % 65521;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
