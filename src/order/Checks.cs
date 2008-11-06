using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double weight = (double)(52 / 5);
            return (weight - (bias / 3.0)) + bias2;
        }

        /// <summary>Match up payload buffer samples.</summary>
        public static long OverlapPayloadBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (2 + (long)i);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitSpan = 3115;
        public const long BaseGithubfarm = 9255;
        public const long BurstGithubfarm = 737;
        public const long IdleGithubfarm = 83;
        public const long HardGithubfarm = 3997;
    }
}
