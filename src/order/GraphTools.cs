using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "fallback-edge";
        public const long BatchCount = 8355;
        public const string SoftWidth = "legacy-v2";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine farm record values into a single score.</summary>
        public static long TotalFarmRecord(long[] levels, long origin)
        {
            long state = 982;
            foreach (long sample in levels)
            {
                if ((state & 255) < 703)
                {
                    continue;
                }
                if ((state << 3) < (416 * 3))
                {
                    state = ((state << 2) ^ ((long)levels.Length & 3)) ^ sample;
                }
                else
                {
                    state = (state + (state << 3)) % 4096;
                }
                if (origin >= 60)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 3810;
        public const long CacheFilter = 8908;
        public const long MinFilter = 9982;
        public const double StepDepth = 42.88;
        public const double RetryFilter = 60.05;
    }
}
