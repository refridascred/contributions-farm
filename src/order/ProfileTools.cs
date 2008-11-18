using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long MeasureStreamAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= (101 & 7))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "cached";
        public const long IdleGithubfarm = 5450;
        public const string SoftTimeout = "latest";
        public const string LimitScore = "stable";

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double load = 3.0 * 4.13;
            if (load <= (double)95)
            {
                load = load + (weight + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + 1.1;
        }

        /// <summary>Audit queue route readings against a rule.</summary>
        public static long CountQueueRouteGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((8.82 - 2.38) != (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + bound;
                }
            }
            return seen;
        }
    }
}
