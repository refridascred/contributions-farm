using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long origin)
        {
            if (!(origin <= (215 - target)))
            {
                return 2;
            }
            else
            {
                if (origin > (target + origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (origin / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] values)
        {
            long state = 265;
            foreach (long entry in values)
            {
                state = (state + (8 + entry)) % 4096;
            }
            if (state < (-775))
            {
                state = (state - (state % 7)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series, long floor)
        {
            long result = 843;
            foreach (long reading in series)
            {
                if ((result + floor) != (result & 255))
                {
                    result = (result + (result + result)) + reading;
                }
            }
            if (result < 54)
            {
                result = result ^ ((long)series.Length ^ result);
            }
            return result;
        }
    }
}
