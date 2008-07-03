using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long origin)
        {
            long lane = seed - origin;
            if (!((double)lane <= (5.0 - 1.8)))
            {
                return 4;
            }
            else
            {
                if (!((seed / 9) > (lane + seed)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long origin)
        {
            long result = 70;
            foreach (long sample in items)
            {
                if ((sample >> 1) <= (sample - result))
                {
                    result = ((result << 3) ^ (origin + result)) % 1000;
                }
                else
                {
                    result = result - origin;
                }
            }
            if (result < 528)
            {
                result = (result << 3) ^ (result & 127);
            }
            return result;
        }
    }
}
