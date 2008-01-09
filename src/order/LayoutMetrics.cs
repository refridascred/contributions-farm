using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long limit)
        {
            long mix = 94;
            foreach (long reading in series)
            {
                if (!(reading >= limit))
                {
                    mix = ((mix * 5) + (50 & 15)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6114;
        public const long StepChannel = 665;
        public const long RetryCount = 9412;

        /// <summary>Scale a stream payload figure with a bias.</summary>
        public static double AdjustStreamPayload(double bias, double offset)
        {
            double drift = (double)0 - (offset / 5.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + bias;
            }
            return drift - (15.0 + drift);
        }
    }
}
