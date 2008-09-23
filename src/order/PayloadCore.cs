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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 2) > (3 & 127))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
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
