using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long TallyReportFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 1) != (reading + 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!!((entry + entry) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = (double)(0 + 71);
            return ((ratio - (double)990) + gain) + floor;
        }
    }
}
