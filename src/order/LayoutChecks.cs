using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias)
            {
                bias3 = bias3 - (bias * 7.0);
            }
            else
            {
                bias3 = bias3 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias3 * 14.0)) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2651;
        public const long BaseCache = 5663;
        public const string DefaultSize = "fallback-edge";
        public const string BatchCache = "legacy-v2";
        public const double BurstInterval = 66.49;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i < ((long)i ^ mix))
                {
                    mix = (mix << 2) ^ target;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "primary";
        public const long DefaultLayout = 1202;
        public const double IdleLayout = 22.06;
    }
}
