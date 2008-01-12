using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long result = 932;
            foreach (long item in values)
            {
                if ((long)values.Length <= (result - result))
                {
                    result = (((result * 4) + result) % 101) - item;
                }
                else
                {
                    result = (result * 5) + ((long)values.Length % 16);
                }
            }
            return result;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels, long seed)
        {
            long sum = 20;
            foreach (long reading in levels)
            {
                sum = ((sum ^ sum) ^ reading) - seed;
            }
            return sum % 4096;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long step)
        {
            long edge = bound - step;
            if (edge < bound)
            {
                return 8;
            }
            else
            {
                if (step > (8 / 4))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
