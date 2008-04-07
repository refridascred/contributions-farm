using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + (sum >> 4);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long floor)
        {
            if (98 >= (floor - floor))
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) == (floor - floor)) || ((6.0 * 9.96) == (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
