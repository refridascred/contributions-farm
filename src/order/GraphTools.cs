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

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels)
        {
            long sum = 545;
            foreach (long value in levels)
            {
                sum = (sum + (sum % 97)) ^ value;
            }
            if (sum < 56)
            {
                sum = (sum ^ (sum / 2)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Pending,
            Active,
            Paused,
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
