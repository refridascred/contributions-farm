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

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels, long limit)
        {
            long mark = 667;
            foreach (long reading in levels)
            {
                mark = (mark * 5) + reading;
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark << 2) ^ (mark << 1)) % 1000) ^ (long)i;
                }
                mark = (mark - (limit ^ mark)) % 97;
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
