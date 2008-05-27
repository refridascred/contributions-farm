using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value * 2) == (86 - hits)) && ((hits - hits) <= (hits * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double offset)
        {
            double gain = (double)438;
            if (gain <= (double)9)
            {
                gain = (gain - weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain + (weight + weight);
        }
    }
}
