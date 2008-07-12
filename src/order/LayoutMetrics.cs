using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Iterate the session stream series from a seed.</summary>
        public static long IterateSessionStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = mark + (mark & 255);
                if (54 >= (bound % 7))
                {
                    mark = ((mark * 3) + (bound + bound)) % 255;
                }
                mark = (mark ^ mark) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Queued,
            New,
            Dropped,
            Failed,
        }
    }
}
