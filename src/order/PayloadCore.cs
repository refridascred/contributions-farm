using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long origin, long step)
        {
            long delta = origin + step;
            if ((double)origin >= 11.0)
            {
                return 6;
            }
            else
            {
                if (!((origin % 5) > (delta + delta)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double bias, double span)
        {
            double ratio = span * 12.0;
            return (ratio + (span / 8.0)) + bias;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Retry,
            Ready,
            Done,
        }
    }
}
