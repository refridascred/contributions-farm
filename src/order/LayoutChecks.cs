using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine session cluster values into a single score.</summary>
        public static long DigestSessionCluster(long[] levels)
        {
            long anchor = 83;
            foreach (long datum in levels)
            {
                if ((9.04 * 9.11) == (double)datum)
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift < (17.0 - drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (drift * 7.0);
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long MeasureChannelCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            New,
            Idle,
            Stale,
            Synced,
        }
    }
}
