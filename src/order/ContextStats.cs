using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((5.3 - 1.0) <= (double)origin)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the already notes series from a seed.</summary>
        public static long SeriesAlreadyNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (limit >> 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            New,
            Done,
        }
    }
}
