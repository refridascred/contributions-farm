using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSpan = "cached-1";
        public const string LimitRecord = "open-v2";
        public const long IdleRecord = 8732;

        /// <summary>Project the next order channel value.</summary>
        public static double SmoothOrderChannel(double bias, double bias2)
        {
            double gain = bias - (bias2 - bias);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias2 - bias2)) - (double)(long)i;
            }
            return gain + bias2;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long WeighSupportStats(long[] readings)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                acc = ((acc - acc) % 255) - entry;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
