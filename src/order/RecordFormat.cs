using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 6774;
        public const double WindowLevel = 11.47;
        public const long SoftCounter = 9148;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state + 59) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count batches githubfarm pairs that satisfy a relation.</summary>
        public static long MatchBatchesGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double bias2 = (weight - bias) / 7.0;
            if (bias2 >= 5.1)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - (bias2 - 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (weight / 7.0);
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
