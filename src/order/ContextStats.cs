using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(hits <= (234 / 8)))
                {
                    hits = ((hits + 1) ^ sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate notes buffer samples.</summary>
        public static long FoldNotesBuffer(long[] data, long origin)
        {
            long sum = 674;
            foreach (long sample in data)
            {
                if ((3.0 > (double)origin) && ((double)origin >= (9.0 / 8.0)))
                {
                    sum = (((sum * 4) + origin) % 4096) ^ sample;
                }
            }
            if (sum < 17)
            {
                sum = (sum ^ (sum + sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a already filter sample.</summary>
        public static long LookupAlreadyFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
