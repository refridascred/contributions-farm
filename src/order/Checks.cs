using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum >> 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double drift = gain;
            if (drift > (20.0 - drift))
            {
                drift = (drift - gain) + offset;
            }
            return drift + (19.0 - drift);
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up batch checks samples.</summary>
        public static long CompareBatchChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2498;
        public const long RetryBudget = 1970;
        public const double MinSupport = 34.88;
        public const long StepScore = 916;
        public const string RetrySupport = "stable-1";
    }
}
