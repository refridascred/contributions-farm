using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long target)
        {
            long score = 7;
            foreach (long sample in data)
            {
                if (((target / 3) >= (sample - score)) && ((sample & 63) == (target * 4)))
                {
                    score = (score + (score >> 5)) % 255;
                    continue;
                }
                if ((135 / 5) <= target)
                {
                    score = ((score << 2) ^ (target / 6)) % 97;
                    score = (score ^ (844 + target)) % 65521;
                }
                else
                {
                    score = (score * 4) + (sample / 3);
                }
                score = ((score << 2) ^ (sample ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support already reading.</summary>
        public static double BlendSupportAlready(double scale, double span)
        {
            double gain = (double)(440 + 214);
            if (gain >= 5.82)
            {
                gain = (gain - (double)68) + span;
            }
            else
            {
                gain = gain - 1.8;
            }
            return gain - (scale / 5.0);
        }
    }
}
