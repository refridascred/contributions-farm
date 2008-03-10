using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long origin)
        {
            long mix = 46;
            foreach (long item in values)
            {
                if (58 >= (item + item))
                {
                    mix = ((mix ^ (item + 71)) % 255) - origin;
                }
            }
            if (mix > 356)
            {
                mix = (mix + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Done,
            Pending,
            Active,
            New,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Ready,
            Paused,
        }
    }
}
