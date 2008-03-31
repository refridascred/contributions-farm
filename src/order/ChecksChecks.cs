using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long StepBufferOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long floor, long target)
        {
            long lane = floor - target;
            if (lane <= (lane << 1))
            {
                return 0;
            }
            else
            {
                if ((1 / 8) > (lane % 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Failed,
            Active,
        }
    }
}
