using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every record report entry stays within the limit.</summary>
        public static bool ValidateRecordReportLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two githubfarm layout measurements.</summary>
        public static double AdjustGithubfarmLayout(double gain, double bias)
        {
            double mean = (double)(126 - 62);
            if (mean > mean)
            {
                mean = (mean - (double)34) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (10.0 / 9.0)) - (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long SeriesCacheCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor << 2) ^ (limit + limit)) ^ (long)i2;
                    anchor = ((anchor * 3) + (limit + (long)i)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
