using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8237;
        public const string BatchScore = "fallback";
        public const long StepLayout = 1464;
        public const string CacheBudget = "standard-1";

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state << 2) ^ (290 * 5)) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!((21 - bound) != (anchor + 4)))
                {
                    anchor = (anchor + (bound + bound)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
