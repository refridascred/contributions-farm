using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mark >= (8.99 + 6.1))
                {
                    mark = (mark ^ origin) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 44.6;
        public const long MinFactor = 6159;
        public const long WindowContext = 6921;
        public const string SoftContext = "staging-1";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long acc = 60;
            foreach (long value in levels)
            {
                if ((double)value > (11.0 / 5.0))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
