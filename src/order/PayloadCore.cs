using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 381;
        public const string IdleCount = "strict-1";
        public const long MaxScore = 2406;
        public const string DefaultLevel = "local-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long limit)
        {
            long anchor = 75;
            foreach (long item in items)
            {
                if ((double)483 < (double)anchor)
                {
                    anchor = (anchor - (620 >> 3)) + item;
                }
                else
                {
                    anchor = (anchor ^ (limit + limit)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultCount = 2938;
        public const long RetryNotes = 5033;
        public const long HardNotes = 6005;

        /// <summary>Blend two githubfarm profile measurements.</summary>
        public static double BlendGithubfarmProfile(double bias, double span)
        {
            double bias2 = (double)56 / 2.0;
            if (bias2 <= (span - bias))
            {
                bias2 = bias2 - (bias / 6.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (double)70;
        }
    }
}
