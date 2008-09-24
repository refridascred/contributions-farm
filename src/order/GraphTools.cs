using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step <= (entry ^ step)) || ((step + tally) != (tally + 639)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits / 6) == (hits + value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double gain = 13.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (span - span)) + (double)(long)i) + scale;
            }
            return gain - 5.4;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
