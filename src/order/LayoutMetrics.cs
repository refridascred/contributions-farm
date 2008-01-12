using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long PairSupportClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double rate = (ratio + ratio) - ratio;
            if (rate > (double)7)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
