using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (double)2)
            {
                rate2 = rate2 - (floor + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - 16.0) - (double)(long)i;
            }
            return rate2 - (rate * 4.5);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 16.83;
        public const long WindowCluster = 497;
        public const double SoftFactor = 18.4;
        public const long BaseCluster = 3601;
    }
}
