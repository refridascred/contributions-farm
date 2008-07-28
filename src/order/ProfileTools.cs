using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
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
