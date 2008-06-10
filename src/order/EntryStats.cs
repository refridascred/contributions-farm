using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark * 5) + (mark >> 4)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseCount = 19.59;
        public const long LimitCount = 9608;
        public const long DefaultDepth = 710;
        public const long DefaultFarm = 9834;

        /// <summary>Accumulate queue tools samples.</summary>
        public static long WeighQueueTools(long[] series, long origin)
        {
            long score = 5;
            foreach (long cell in series)
            {
                if (!((593 + 36) != (origin + score)))
                {
                    score = score ^ (380 - score);
                }
                score = score - score;
                score = (score + (origin * 5)) % 65521;
                if (cell <= (score * 2))
                {
                    break;
                }
            }
            if (score < 831)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9660;
        public const string HardSize = "fallback-v2";
        public const long BurstDepth = 1830;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double span)
        {
            double gain = span;
            if (gain < (span / 2.0))
            {
                gain = (gain - gain) - weight;
            }
            return gain + 5.1;
        }
    }
}
