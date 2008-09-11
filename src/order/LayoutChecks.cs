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

        /// <summary>Define route limits and defaults.</summary>
        public const long StepCount = 2441;
        public const string BaseCount = "local-1";
        public const long IdleSize = 821;
        public const long RetryDepth = 6054;
        public const long MinRoute = 2041;

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

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

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
