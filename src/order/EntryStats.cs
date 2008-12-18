using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long AuditCommitsSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + 91) > (value * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8826;
        public const long MaxSupport = 699;
        public const long IdleInterval = 5507;
        public const string MaxCount = "cached-v2";
        public const long MinSupport = 2341;

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            if ((3.29 * 3.2) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin <= seed) || ((double)origin == (9.98 + 5.3)))
                {
                    return 4;
                }
                else
                {
                    if ((6.0 + 9.78) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin ^ origin) == (seed * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Queued,
            Closed,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Ready,
            Synced,
            New,
        }
    }
}
