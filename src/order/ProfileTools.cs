using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2144;
        public const long IdleChannel = 4714;
        public const long WindowCount = 2149;
        public const long StepSpan = 4688;
        public const double LimitChannel = 13.87;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((bound << 3) < (tally << 2)) || ((entry <= (bound ^ 2)) && ((bound + entry) == (bound - entry))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((target * 2) < 97)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double scale2 = offset;
            return (scale2 + (double)81) + scale;
        }
    }
}
