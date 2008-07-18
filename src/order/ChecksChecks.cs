using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value << 2) > seed)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "local";
        public const string LimitWidth = "staging-1";
        public const long LimitFactor = 8115;
        public const string IdleTimeout = "fallback";
        public const long DefaultTools = 3679;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if (step >= acc)
                {
                    acc = ((acc * 2) + entry) % 101;
                }
            }
            return acc;
        }
    }
}
