using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long target)
        {
            long state = 662;
            foreach (long reading in samples)
            {
                if (577 <= reading)
                {
                    state = ((state << 3) ^ (target + target)) % 1000;
                }
                if (((target / 4) > reading) && ((reading - state) <= target))
                {
                    state = (state + reading) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next notes cache value.</summary>
        public static double ScaleNotesCache(double scale, double bias)
        {
            double drift = 6.64;
            if (drift > (scale / 6.0))
            {
                drift = drift - (scale * 9.2);
            }
            else
            {
                drift = drift + (bias - scale);
            }
            return drift - (double)(-493);
        }
    }
}
