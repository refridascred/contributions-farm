using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double weight = (double)(919 % 2);
            if (weight > 3.97)
            {
                weight = (weight - (weight - bias)) - scale;
            }
            return weight - (double)958;
        }

        /// <summary>Find the first tools window entry that matches the target.</summary>
        public static long FindToolsWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
