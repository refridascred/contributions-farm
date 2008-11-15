using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((slot & 15) > (slot * 5))
            {
                return 0;
            }
            else
            {
                if (!((slot & 63) <= floor2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((origin << 3) != (origin >> 4))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
