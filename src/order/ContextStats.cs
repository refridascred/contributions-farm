using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Idle,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long origin)
        {
            if ((double)origin >= (4.2 + 1.48))
            {
                return 3;
            }
            else
            {
                if ((493 + target) >= (origin % 12))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
