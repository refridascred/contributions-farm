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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Draft,
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
