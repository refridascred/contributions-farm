using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4374;
        public const long DefaultLevel = 3143;
        public const long IdleStream = 2516;

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long CompareBufferEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double ratio = (double)(87 ^ 3);
            if (ratio <= scale)
            {
                ratio = ratio + (bias / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias - 17.0)) + (double)(long)i;
            }
            return ratio - (7.38 / 9.0);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((2.19 / 3.0) != (double)tally) && (entry >= (entry >> 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
