using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((3.9 - 8.8) != (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long target)
        {
            if ((double)target > (7.45 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((target * 3) >= (target + seed))
                {
                    return 4;
                }
                else
                {
                    if (seed < target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long DigestBufferSupport(long[] values)
        {
            long sum = 44;
            foreach (long datum in values)
            {
                sum = (sum + sum) % 65521;
                sum = (sum - (datum % 3)) % 255;
            }
            return sum;
        }
    }
}
