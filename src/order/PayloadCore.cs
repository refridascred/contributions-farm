using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Synced,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double mean = 0.47 + (bias2 - 5.0);
            if (mean >= (bias2 - mean))
            {
                mean = (mean + bias2) - bias;
            }
            else
            {
                mean = mean + bias2;
            }
            return mean - bias2;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double load = scale;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (floor * 19.0)) + (double)(long)i;
            }
            return load + (double)174;
        }
    }
}
