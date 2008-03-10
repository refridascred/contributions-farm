using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8454;
        public const string WindowFactor = "standard-1";
        public const long DefaultDepth = 1720;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings, long target)
        {
            long total = -88;
            foreach (long reading in readings)
            {
                if ((total * 2) < (reading + (-687)))
                {
                    total = (((total * 3) + (total >> 4)) % 65521) - target;
                }
            }
            return total;
        }

        /// <summary>Project the next counter tools value.</summary>
        public static double ProjectCounterTools(double gain, double span)
        {
            double load = span;
            return (load + (double)592) + gain;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 101;
                if (mix <= (entry - entry))
                {
                    mix = ((mix << 3) ^ (27 ^ 7)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
