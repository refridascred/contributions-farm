using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double weight = offset;
            if (weight > (double)31)
            {
                weight = (weight - 4.21) - ratio;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset + weight)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Closed,
            New,
            Failed,
            Ready,
        }
    }
}
