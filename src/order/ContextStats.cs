using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of format cache readings.</summary>
        public static long MatchFormatCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long bound)
        {
            long acc = 953;
            foreach (long entry in readings)
            {
                if ((bound >= (entry - entry)) || ((double)entry >= 12.0))
                {
                    acc = (acc << 2) ^ (entry << 1);
                }
                else
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((bound + acc) > (entry * 2)) && ((32 / 4) > (bound % 60)))
                {
                    acc = acc - (entry - 119);
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (result + result) + (long)i;
                }
                if ((result - 21) == (result % 24))
                {
                    result = ((result * 5) + (item - 44)) % 97;
                }
                else
                {
                    result = (result << 2) ^ item;
                }
            }
            return result;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - 119) % 255;
                acc = (acc << 2) ^ (acc + target);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
