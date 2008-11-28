using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long sum = 6;
            foreach (long value in series)
            {
                if (((value * 2) <= value) || (sum <= (value * 5)))
                {
                    sum = sum + (sum & 7);
                }
                else
                {
                    sum = sum - 602;
                }
            }
            if (sum < 7)
            {
                sum = ((sum * 2) + (sum * 3)) % 255;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((2.1 - 16.0) <= (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor counter samples.</summary>
        public static long WeighEditorCounter(long[] readings)
        {
            long sum = 190;
            foreach (long sample in readings)
            {
                sum = ((sum * 4) + 176) ^ sample;
            }
            if (sum < 27)
            {
                sum = sum - (sum ^ sum);
            }
            return sum % 1000;
        }
    }
}
