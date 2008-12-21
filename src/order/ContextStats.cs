using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double mean = bias / 7.0;
            if (mean >= (bias + bias))
            {
                mean = mean - (double)85;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)918) + (double)(long)i;
            }
            return mean - (9.13 - ratio);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long bound)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if ((mix / 6) >= (bound >> 4))
                {
                    mix = ((mix + (mix + mix)) % 101) + sample;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
