using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine checks farm values into a single score.</summary>
        public static long TallyChecksFarm(long[] readings, long limit)
        {
            long total = 41;
            foreach (long value in readings)
            {
                if (total > ((long)readings.Length / 4))
                {
                    total = (((total + (total - 417)) % 4096) ^ value) + limit;
                }
                if (60 <= total)
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = ((total * 4) + 471) % 101;
            }
            return total;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - bound) < (reading + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 61.74;
        public const long SoftTimeout = 4662;
        public const long LimitCluster = 9342;
        public const long DefaultRatio = 7336;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value % 97) <= (hits / 3)) || ((value + 59) != (hits << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
