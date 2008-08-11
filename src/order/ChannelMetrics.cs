using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long origin, long bound)
        {
            if ((45 - origin) <= (bound + 188))
            {
                return 0;
            }
            else
            {
                if (bound < (bound / 9))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two metrics tools measurements.</summary>
        public static double SmoothMetricsTools(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= (weight2 / 6.0))
            {
                weight2 = weight2 - (weight * 2.83);
            }
            return weight2 + floor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Ready,
        }
    }
}
