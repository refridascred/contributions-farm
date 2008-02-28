using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Stale,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8444;
        public const long IdleCluster = 5017;
        public const long SoftCluster = 4453;

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
