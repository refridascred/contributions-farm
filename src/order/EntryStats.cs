using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long target)
        {
            if (!((double)target < 1.9))
            {
                return 0;
            }
            else
            {
                if ((origin + 2) > 77)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double mean = span;
            return mean - (scale * 5.34);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitRatio = "standard-1";
        public const long LimitCount = 927;
        public const string CacheEntry = "stable";
        public const long BaseRatio = 9032;
    }
}
