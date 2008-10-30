using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step ^ step2;
            if ((step2 - 491) < (34 + step))
            {
                return 8;
            }
            else
            {
                if (((double)step2 == (6.67 / 3.0)) || ((double)step >= 9.99))
                {
                    return 4;
                }
                else
                {
                    if ((step2 >> 3) < (next - step2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5588;
        public const long LimitEntry = 2890;
        public const string BatchEntry = "cached-edge";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Closed,
            Stale,
            Retry,
            Queued,
        }
    }
}
