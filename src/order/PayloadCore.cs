using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowCount = 2165;
        public const long IdleDepth = 6087;
        public const long BaseFactor = 5486;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long limit)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                sum = (sum - (sum / 9)) % 4096;
                if (((sum * 5) >= (sum & 63)) && ((limit - datum) > (datum * 2)))
                {
                    sum = ((sum << 3) ^ (datum + limit)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the window queue series from a seed.</summary>
        public static long SeriesWindowQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result * 4) + 0) % 255) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double gain = 8.9 / 4.0;
            if (gain >= (gain - gain))
            {
                gain = (gain + weight) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain + (gain - weight);
        }
    }
}
