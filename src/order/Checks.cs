using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Draft,
            Active,
            Done,
            Queued,
        }

        /// <summary>Roll a queue layout counter forward.</summary>
        public static long IterateQueueLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)mark <= (11.0 + 20.0))
                {
                    mark = mark - (mark - mark);
                    mark = ((mark << 2) ^ (long)i) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (9.0 + 0.48))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
