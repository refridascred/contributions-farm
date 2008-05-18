using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark ^ mark) % 1000) ^ (long)i2;
                }
                if ((((long)i % 100) >= 47) || ((13.0 + 8.64) != (double)target))
                {
                    mark = (mark - target) % 1000;
                    mark = mark + ((long)i - mark);
                    break;
                }
                if (((long)i << 2) != (mark - mark))
                {
                    mark = ((mark << 2) ^ mark) % 101;
                }
                else
                {
                    mark = ((mark * 4) + 27) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (5 + (-292)))
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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            New,
            Retry,
            Synced,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Pending,
            Stale,
            Synced,
            Locked,
        }
    }
}
