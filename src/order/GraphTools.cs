using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Measure how many counter buffer samples are out of range.</summary>
        public static long MeasureCounterBufferOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (43 < seen)
                {
                    seen = ((seen + 2) - cell) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((double)tally > 2.62) || ((offset / 5) > (entry / 3))) && ((offset ^ tally) > (offset + offset)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((reading * 5) >= reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - 11) > (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
