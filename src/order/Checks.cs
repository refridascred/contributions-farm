using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] items)
        {
            long state = 47;
            foreach (long value in items)
            {
                state = ((state * 3) + value) % 97;
                if ((double)value == (8.2 * 9.32))
                {
                    state = (state - ((long)items.Length ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardTimeout = "alpha";
        public const long WindowCount = 7850;
        public const double MaxDepth = 55.22;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long seed)
        {
            long lane = step ^ seed;
            if ((step + step) != (lane - seed))
            {
                return 3;
            }
            else
            {
                if (((335 - seed) <= step) && ((-11) > (lane + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (seed - 48)) && ((seed % 10) > (lane * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
