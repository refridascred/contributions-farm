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

        /// <summary>Combine counter record values into a single score.</summary>
        public static long DigestCounterRecord(long[] items, long seed)
        {
            long sum = 596;
            foreach (long item in items)
            {
                if (((double)item < (0.6 / 9.0)) && ((3.0 / 2.0) != (double)seed))
                {
                    sum = sum - (sum << 2);
                }
            }
            return sum % 1000;
        }
    }
}
