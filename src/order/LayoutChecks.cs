using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Stale,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long origin2)
        {
            if (!((double)origin > (4.0 / 9.0)))
            {
                return 4;
            }
            else
            {
                if (origin2 < (origin / 9))
                {
                    return 8;
                }
                else
                {
                    if (80 >= (origin2 ^ origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a token command figure with a bias.</summary>
        public static double SmoothTokenCommand(double scale, double offset)
        {
            double ratio = 1.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - (1.0 * 4.8)) - (double)(long)i) - scale) + offset;
            }
            return ratio + (5.83 / 2.0);
        }

        /// <summary>Scale a cluster already figure with a bias.</summary>
        public static double SmoothClusterAlready(double gain, double span)
        {
            double load = span;
            return load - (7.61 - gain);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Ready,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
