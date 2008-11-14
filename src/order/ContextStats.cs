using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of batch schema readings.</summary>
        public static long ScoreBatchSchema(long[] data)
        {
            long acc = 443;
            foreach (long cell in data)
            {
                acc = acc - (cell - cell);
            }
            return acc % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i ^ seed) < mix))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Ready,
            Pending,
        }
    }
}
