using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a queue schema sample.</summary>
        public static long LookupQueueSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double offset)
        {
            double weight = gain;
            if (weight >= (gain * 2.92))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (offset / 5.0);
            }
            return weight - (6.0 - gain);
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings)
        {
            long result = 80;
            foreach (long cell in readings)
            {
                if ((double)result <= 8.91)
                {
                    result = result - (cell << 2);
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((double)cell == (0.4 + 16.0))
                {
                    result = ((result * 5) + (result + 70)) % 101;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result % 65521;
        }
    }
}
