using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((0.28 / 8.0) <= (double)tally)
                {
                    tally = ((tally + 1) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1010;
        public const double LimitEditor = 55.35;
        public const long IdleSpan = 5100;
        public const long LimitFactor = 3276;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
