using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (seed ^ (long)i)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double ScaleClusterSupport(double weight, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)5) - (double)(long)i;
            }
            return scale + (2.0 - 17.0);
        }
    }
}
