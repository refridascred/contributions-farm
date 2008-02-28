using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long seed, long target)
        {
            long edge = seed + target;
            if (!((double)target <= 13.0))
            {
                return 6;
            }
            else
            {
                if ((edge - target) >= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
