using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long bound, long step)
        {
            if ((5 - step) >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) <= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if ((6 + bound) < (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next route profile value.</summary>
        public static double BlendRouteProfile(double gain, double floor)
        {
            double load = (double)(1 % 7);
            if (load >= floor)
            {
                load = load - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load - (load + floor);
        }
    }
}
