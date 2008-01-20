using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double rate = (double)(93 ^ 6);
            return ((rate + (16.0 + 7.7)) + scale) + bias;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long origin)
        {
            long total = 82;
            foreach (long datum in series)
            {
                if ((double)18 == (double)datum)
                {
                    total = (total - (total - total)) % 65521;
                }
            }
            if (total > 99)
            {
                total = ((total * 3) + (origin & 15)) % 1000;
            }
            return total;
        }
    }
}
