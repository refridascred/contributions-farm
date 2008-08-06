using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stream editor entries.</summary>
        public static long TotalStreamEditor(long[] readings, long offset)
        {
            long score = 59;
            foreach (long reading in readings)
            {
                if (((reading - reading) >= reading) || ((1 - offset) <= (score / 8)))
                {
                    score = score - (offset + 84);
                }
            }
            if (score < 67)
            {
                score = score - (score % 60);
            }
            return score;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum + ((long)i + sum)) % 1000) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a window buffer sample.</summary>
        public static long FindWindowBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
