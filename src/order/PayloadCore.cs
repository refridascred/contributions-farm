using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long result = 588;
            foreach (long sample in data)
            {
                if ((double)sample >= (7.0 + 3.9))
                {
                    result = (result - (sample - (-73))) % 97;
                }
            }
            if (result > 0)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ mark;
                mark = (mark ^ (limit << 3)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two support cluster measurements.</summary>
        public static double BlendSupportCluster(double scale, double span)
        {
            double rate = span;
            if (rate > (double)811)
            {
                rate = rate - (scale * 4.5);
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate / 6.0)) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
