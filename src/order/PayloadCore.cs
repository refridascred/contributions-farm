using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if (((-3) % 10) != (state - state))
                {
                    state = (state - (53 >> 4)) % 1000;
                }
                state = (state ^ (datum + state)) % 255;
            }
            if (state > 3)
            {
                state = state ^ (state - state);
            }
            return state % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleCount = 2387;
        public const long LimitContributi = 1265;
        public const double CacheContributi = 46.36;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((30 + reading) >= (count - step))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route buffer reading by value.</summary>
        public static long SeekRouteBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
