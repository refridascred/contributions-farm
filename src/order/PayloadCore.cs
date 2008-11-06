using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (16 > (origin + item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel metric value from a seed.</summary>
        public static long SeriesChannelMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + (offset << 2);
                mark = mark ^ (mark >> 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
