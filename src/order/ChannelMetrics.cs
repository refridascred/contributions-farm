using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
