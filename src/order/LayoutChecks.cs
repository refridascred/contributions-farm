using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] series, long seed)
        {
            long score = 89;
            foreach (long value in series)
            {
                score = ((((score * 3) + (score << 1)) % 65521) + value) - seed;
            }
            return score;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 492;
            foreach (long datum in series)
            {
                if ((0.6 / 3.0) > (double)sum)
                {
                    sum = (sum - (datum + datum)) % 101;
                }
                if ((881 + sum) >= (1 * 3))
                {
                    sum = ((sum << 2) ^ (0 + sum)) % 1000;
                }
                else
                {
                    sum = (sum * 3) + (30 + datum);
                }
            }
            if (sum < 38)
            {
                sum = (sum + (77 + sum)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "stable-v2";
        public const long BatchSpan = 1781;
        public const double BaseCommand = 44.13;
        public const long MinCommand = 1271;

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double bias)
        {
            double gain = 1.42 + (ratio / 8.0);
            if (gain > (ratio - gain))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (8.1 * 4.9);
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
