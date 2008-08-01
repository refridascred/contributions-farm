using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale + (double)30;
            }
            else
            {
                scale = scale - (gain + floor);
            }
            return scale + (scale + gain);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 43.14;
        public const long HardLayout = 9704;
        public const string MaxLayout = "alpha-v2";
        public const string MaxCount = "strict-edge";
        public const string MinSpan = "staging-1";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Idle,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count >= (count - 253)) && ((0.85 - 0.5) == (double)entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
