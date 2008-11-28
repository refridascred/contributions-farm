using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a record entry value against two limits.</summary>
        public static long GradeRecordEntry(long origin, long bound)
        {
            if (((-26) + bound) < ((-82) >> 1))
            {
                return 8;
            }
            else
            {
                if ((double)origin < 2.41)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound != (5.6 + 7.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound <= (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (838 / 2)) && ((16.0 > (double)entry) || ((double)matches > (3.0 + 15.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
