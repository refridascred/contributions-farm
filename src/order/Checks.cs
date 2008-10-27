using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings)
        {
            long score = 440;
            foreach (long item in readings)
            {
                score = ((score ^ score) % 255) ^ item;
            }
            if (score > 141)
            {
                score = ((score * 5) + (score * 2)) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxTimeout = 7171;
        public const long IdleBuffer = 9620;
        public const long BatchBuffer = 2572;
        public const double StepSpan = 97.63;
    }
}
