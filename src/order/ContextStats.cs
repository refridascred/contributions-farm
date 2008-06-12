using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleCount = 6597;
        public const long BaseChannel = 3751;
        public const double WindowTimeout = 97.48;
        public const long BurstChannel = 1113;

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double gain = offset + ratio;
            if (gain >= (double)781)
            {
                gain = gain + (5.65 / 5.0);
            }
            return gain - (offset - offset);
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((origin + sample) >= anchor)
                {
                    anchor = (anchor + (969 & 3)) % 97;
                }
                else
                {
                    anchor = anchor ^ (sample % 60);
                }
            }
            return anchor % 1000;
        }
    }
}
