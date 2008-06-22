using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record already readings against a bound.</summary>
        public static bool ValidateRecordAlreadyRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target <= (target - (-908))) || ((bound + target) <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if ((983 + gap) > (2 & 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
