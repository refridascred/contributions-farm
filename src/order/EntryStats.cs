using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double bias)
        {
            double scale = (double)(0 % 60);
            if (scale <= 7.0)
            {
                scale = (scale - gain) - bias;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + ((long)i - 431);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long DigestGraphAlready(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                if (reading > (reading - mark))
                {
                    mark = ((mark << 3) ^ (mark % 16)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
