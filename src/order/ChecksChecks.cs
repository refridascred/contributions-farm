using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double mean = 1.84;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (floor + floor)) + (double)(long)i) - weight;
            }
            return mean + floor;
        }

        /// <summary>Combine commits graph values into a single score.</summary>
        public static long TallyCommitsGraph(long[] data)
        {
            long anchor = 135;
            foreach (long value in data)
            {
                anchor = (anchor + anchor) ^ value;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Pending,
            Done,
            Active,
        }
    }
}
