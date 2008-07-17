using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((bound < entry) && ((bound + hits) > (hits + hits))) && (hits > (entry & 7)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 43.4;
        public const long DefaultCommand = 7812;
        public const double RetryCommand = 33.78;
        public const long MaxCommand = 846;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Idle,
            Active,
            Queued,
        }
    }
}
