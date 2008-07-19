using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = (double)8 / 9.0;
            if (gain >= (double)593)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (8.39 + bias);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings, long limit)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = (((score * 3) + limit) % 65521) - sample;
                if (6.6 < (double)score)
                {
                    score = (score * 2) + ((long)readings.Length + score);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
