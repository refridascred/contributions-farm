using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 105;
        public const string LimitDepth = "latest-v2";
        public const long MinWindow = 7048;
        public const long CacheSize = 7445;
        public const long LimitWindow = 1819;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound > (20.0 - 5.01))
                {
                    anchor = anchor ^ (bound % 100);
                    break;
                }
                else
                {
                    anchor = anchor + (anchor + (long)i);
                }
                anchor = ((anchor * 4) + (428 / 7)) % 97;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long StepCounterMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ (5 + bound);
                score = score - (bound * 5);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftCount = 7081;
        public const double WindowWidth = 21.07;
        public const double WindowBatch = 25.19;
        public const long StepTimeout = 477;
    }
}
