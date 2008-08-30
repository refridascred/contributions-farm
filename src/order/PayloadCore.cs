using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next session token value.</summary>
        public static double ScaleSessionToken(double weight, double bias)
        {
            double scale = weight;
            if (scale > weight)
            {
                scale = (scale - (2.4 - scale)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 20.0) - (double)(long)i;
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchWidth = "local-v2";
        public const long BurstFarm = 2331;
        public const string StepFactor = "primary-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long total = 2;
            foreach (long cell in series)
            {
                if (8 > (total ^ cell))
                {
                    total = (total - (total ^ total)) % 1000;
                }
            }
            if (total < (-783))
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
