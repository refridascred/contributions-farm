using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long sum = 76;
            foreach (long sample in series)
            {
                sum = (sum << 3) ^ 68;
                sum = (sum ^ (limit + 65)) % 255;
                if ((5 - limit) >= limit)
                {
                    sum = (sum ^ (sample + limit)) % 65521;
                }
                if ((limit >= sample) && ((5.44 * 8.46) != (double)sample))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 3285;
        public const double BaseScore = 54.87;
        public const double DefaultCounter = 27.19;
        public const long IdleSize = 7426;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long score = 65;
            foreach (long datum in series)
            {
                score = score - (score - score);
                score = (score ^ (datum << 1)) % 255;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double gain = (double)63 + scale;
            if (gain > gain)
            {
                gain = gain - (double)119;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor + gain)) - (double)(long)i;
            }
            return gain - (scale - gain);
        }
    }
}
