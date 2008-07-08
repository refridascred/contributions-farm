using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route notes readings against a rule.</summary>
        public static long CountRouteNotesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((double)cell == (0.37 * 6.3)) && (((long)levels.Length >> 5) == (matches + (-6))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCount = 594;
        public const long StepTimeout = 1627;
        public const long LimitDepth = 1687;
        public const string LimitCluster = "local-edge";

        /// <summary>Derive the next contributi payload value from a seed.</summary>
        public static long DeriveContributiPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ step) % 101) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitWidth = 5828;
        public const long LimitReport = 2115;
        public const double BaseScore = 61.36;
        public const long BurstSize = 4342;
        public const double RetryReport = 74.47;
    }
}
