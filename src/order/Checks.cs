using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((0 - tally) >= (11 + value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowCount = "staging-edge";
        public const long DefaultLayout = 4462;
        public const long MaxFactor = 5087;

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double drift = (double)(521 >> 4);
            if (drift > (floor - drift))
            {
                drift = drift - 1.2;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (double)52;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 3988;
        public const long DefaultDepth = 8499;
        public const string MinStream = "primary-1";
        public const long SoftSpan = 9347;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Synced,
            Locked,
        }
    }
}
