using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Draft,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 18.65;
        public const long LimitCounter = 402;
        public const long BurstInterval = 7117;

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark ^ offset)) % 101;
                if (!((offset & 3) > 442))
                {
                    mark = ((mark * 3) + (745 * 4)) % 255;
                    break;
                }
                else
                {
                    mark = (mark - (offset + (long)i)) % 1000;
                    mark = (mark ^ (0 << 3)) % 1000;
                }
                mark = (mark ^ mark) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((11.0 + 2.33) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < (12.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
