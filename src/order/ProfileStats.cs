using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a metrics payload figure with a bias.</summary>
        public static double AdjustMetricsPayload(double gain, double span)
        {
            double mean = gain - (double)2;
            if (mean >= gain)
            {
                mean = (mean - gain) - span;
            }
            else
            {
                mean = mean - (mean / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Scale a stream queue figure with a bias.</summary>
        public static double ScaleStreamQueue(double rate, double span)
        {
            double gain = (rate + rate) + 1.0;
            if (gain > 9.23)
            {
                gain = (gain - gain) + span;
            }
            else
            {
                gain = gain - (gain * 2.6);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)333) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
