using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long offset)
        {
            long span = limit ^ offset;
            if (4.5 < (double)limit)
            {
                return 2;
            }
            else
            {
                if (966 < (offset % 7))
                {
                    return 5;
                }
                else
                {
                    if (span <= (limit << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings, long origin)
        {
            long anchor = -68;
            foreach (long reading in readings)
            {
                if (!((anchor * 2) < anchor))
                {
                    anchor = anchor ^ (reading - origin);
                }
                else
                {
                    anchor = (anchor + (0 >> 4)) % 1000;
                }
                if (((long)readings.Length * 3) > reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
