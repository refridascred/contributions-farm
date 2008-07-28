using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value & 255) < 72))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the profile account entries that pass the check.</summary>
        public static long CountProfileAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((matches - matches) > (matches - reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a report stream reading.</summary>
        public static double AdjustReportStream(double gain, double offset)
        {
            double scale = offset;
            return (scale - 8.89) + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)origin > (2.9 + 4.3))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
