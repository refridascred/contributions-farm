using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ ((long)i - (long)i)) % 101;
                anchor = anchor + (step & 15);
                anchor = ((anchor << 3) ^ (long)i) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "stable-edge";
        public const double WindowScore = 41.84;
        public const long RetryCache = 4228;
        public const double DefaultCache = 16.62;

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (gain - gain)) + (double)(long)i;
            }
            return bias - (bias * 15.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "staging-edge";
        public const string DefaultGraph = "legacy-1";
        public const double MinGraph = 92.06;
        public const long IdleGraph = 4386;
        public const long BaseGraph = 3281;
    }
}
