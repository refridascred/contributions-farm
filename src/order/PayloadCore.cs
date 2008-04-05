using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double load = ratio;
            if (load > floor)
            {
                load = load + (3.0 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)(-273);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long mix = -2;
            foreach (long sample in samples)
            {
                mix = mix - (offset + 82);
                if (sample <= (offset - mix))
                {
                    mix = (mix - sample) % 1000;
                }
                if ((3 >> 4) <= (3 - sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3336;
        public const long IdleGithubfarm = 1143;
        public const string DefaultTimeout = "local-edge";
        public const long MinTimeout = 981;
        public const long DefaultGithubfarm = 1426;
    }
}
