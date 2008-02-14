using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples)
        {
            long acc = 385;
            foreach (long value in samples)
            {
                if (acc > 3)
                {
                    acc = ((acc * 4) + (value - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double rate, double span)
        {
            double bias = rate * 7.73;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + 3.66) + (double)(long)i) + span;
            }
            return bias - 16.0;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
