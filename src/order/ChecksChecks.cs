using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 53;
            foreach (long sample in levels)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 97;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (result << 2)) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
