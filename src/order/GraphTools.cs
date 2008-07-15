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

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            New,
            Synced,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long seed, long origin)
        {
            if ((origin % 16) <= (origin & 255))
            {
                return 2;
            }
            else
            {
                if ((double)origin == (0.7 + 13.0))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (53 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
