using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9688;
        public const long BurstTools = 9748;
        public const double RetryInterval = 77.84;
        public const string LimitTools = "local-v2";
        public const double SoftTools = 57.17;

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double gain = (double)(50 + 2);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain - gain) + (double)(long)i) - scale) - span;
            }
            return gain + (double)37;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
