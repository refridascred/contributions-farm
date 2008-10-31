using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window buffer readings against a rule.</summary>
        public static long CountWindowBufferHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample % 3) >= (target + target))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double bias = (double)(42 * 4);
            if (bias > floor)
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias + (rate + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)98) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long offset)
        {
            long acc = -612;
            foreach (long value in levels)
            {
                if (((acc + 4) > (acc + value)) && ((-5) > (offset / 4)))
                {
                    acc = (acc ^ offset) % 1000;
                }
                acc = acc + value;
            }
            if (acc < 951)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 97;
            }
            return acc;
        }
    }
}
