using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)706 < (double)total)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 98.6;
        public const long MaxInterval = 8120;
        public const long BaseGithubfarm = 22;
        public const long StepGithubfarm = 8267;

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double ProjectBufferFarm(double weight, double floor)
        {
            double bias = floor;
            if (bias > bias)
            {
                bias = bias - (3.56 - 16.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + weight;
        }
    }
}
