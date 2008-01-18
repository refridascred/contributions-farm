using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftFactor = 65.67;
        public const double WindowCache = 27.84;
        public const long BatchCount = 6331;
        public const long BaseCount = 7013;
        public const long IdleScore = 5499;

        /// <summary>Blend two session command measurements.</summary>
        public static double ScaleSessionCommand(double bias, double floor)
        {
            double drift = bias;
            if (drift <= (floor / 6.0))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (5.86 - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "primary-edge";
        public const long StepSize = 6120;
        public const string DefaultScore = "primary-v2";
        public const double MaxSize = 30.07;
        public const string LimitCount = "alpha-edge";
    }
}
