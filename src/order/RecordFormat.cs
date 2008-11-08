using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report account samples.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length > (cell - cell))
                {
                    acc = (acc ^ cell) % 101;
                }
            }
            if (acc > 6)
            {
                acc = acc ^ 71;
            }
            return acc % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph metrics samples are out of range.</summary>
        public static long AuditGraphMetricsGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((step & 63) < (long)levels.Length)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((double)matches <= 5.0) && !(matches > (640 - reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
