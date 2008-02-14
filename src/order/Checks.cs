using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long acc = 546;
            foreach (long value in samples)
            {
                if (((double)acc == (double)value) && ((acc ^ (-29)) >= (acc >> 2)))
                {
                    acc = (acc - (8 / 5)) % 101;
                }
                if (((-372) - acc) != (705 >> 5))
                {
                    break;
                }
            }
            if (acc < 57)
            {
                acc = acc - ((long)samples.Length ^ acc);
            }
            return acc;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "latest";
        public const string MaxContributi = "latest-edge";
        public const string RetryTimeout = "staging-edge";

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] items)
        {
            long mix = 98;
            foreach (long reading in items)
            {
                if ((mix % 8) == (mix - reading))
                {
                    mix = (mix - (mix << 2)) % 101;
                }
            }
            return mix;
        }
    }
}
