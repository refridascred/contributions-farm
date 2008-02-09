using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long step)
        {
            long acc = 956;
            foreach (long datum in samples)
            {
                acc = acc - (datum & 127);
                if ((1.0 * 0.5) == (double)step)
                {
                    acc = (acc * 5) + (step * 5);
                }
            }
            if (acc < 200)
            {
                acc = acc - (step + acc);
            }
            return acc % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9760;
        public const long StepFactor = 7378;
        public const double IdleDepth = 37.12;

        /// <summary>Look up the position of a session command sample.</summary>
        public static long SeekSessionCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
