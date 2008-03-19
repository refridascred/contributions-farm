using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long floor)
        {
            if ((floor / 4) != (target ^ target))
            {
                return 8;
            }
            else
            {
                if ((12 ^ target) <= (target / 6))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Dropped,
            Synced,
            Done,
            New,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long limit, long bound)
        {
            long span = limit + bound;
            if ((limit ^ bound) == (bound / 7))
            {
                return 3;
            }
            else
            {
                if (((-80) >> 5) < (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if ((span + limit) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
