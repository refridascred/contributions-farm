using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                anchor = ((anchor * 3) + anchor) % 65521;
                if (((265 + seed) >= (anchor / 8)) && ((value ^ anchor) < (value * 2)))
                {
                    anchor = (anchor - value) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two counter channel measurements.</summary>
        public static double BlendCounterChannel(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (ratio - ratio))
            {
                gain = gain - (gain * 3.0);
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain - (double)64;
        }
    }
}
