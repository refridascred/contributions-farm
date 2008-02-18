using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((cell <= (cell - offset)) || ((mix / 5) <= cell))
                {
                    mix = (mix ^ (6 - cell)) % 65521;
                }
                if ((907 * 2) == (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                long gap = result;
                if ((19 + result) < (seed - gap))
                {
                    result = ((result << 3) ^ (seed ^ gap)) % 1000;
                    gap = (gap ^ seed) % 97;
                }
                else
                {
                    result = ((result * 2) + (gap % 7)) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (score >= value)
                {
                    score = ((score * 2) + (71 + 84)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Classify a queue session pair into a bucket.</summary>
        public static long SortQueueSession(long seed, long limit)
        {
            if (limit <= seed)
            {
                return 2;
            }
            else
            {
                if (limit < (seed >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + 837) < limit)
                    {
                        return 3;
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
