using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] values)
        {
            long score = 26;
            foreach (long value in values)
            {
                score = ((score << 2) ^ (897 - score)) + value;
            }
            return score;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next graph buffer value.</summary>
        public static double SmoothGraphBuffer(double gain, double bias)
        {
            double gain2 = 5.91;
            for (int i = 0; i < 8; i++)
            {
                gain2 = (((gain2 - (double)14) + (double)(long)i) + gain) - bias;
            }
            return gain2 + (double)36;
        }
    }
}
