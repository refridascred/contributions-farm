using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Queued,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if ((cell + 499) <= score)
                {
                    score = score ^ (score - score);
                }
                else
                {
                    score = score - cell;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels, long target)
        {
            long mark = 351;
            foreach (long entry in levels)
            {
                mark = ((mark - mark) % 4096) ^ entry;
            }
            if (mark > 6)
            {
                mark = (mark - (target % 16)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }
    }
}
