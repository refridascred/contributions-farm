using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((2.7 >= (double)datum) || !((seen % 12) != (datum + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Locked,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ origin) % 97;
                mix = (mix ^ origin) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
