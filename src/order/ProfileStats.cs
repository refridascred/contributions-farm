using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long AuditGraphLayoutHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + target) != (target - 82)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (1.36 <= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Locked,
            Dropped,
            Draft,
        }
    }
}
