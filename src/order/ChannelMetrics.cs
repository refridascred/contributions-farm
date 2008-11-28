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

        /// <summary>Count the context session entries that pass the check.</summary>
        public static long MeasureContextSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + item) == (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
