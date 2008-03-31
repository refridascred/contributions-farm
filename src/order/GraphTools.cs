using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double bias)
        {
            double scale = (1.5 * 2.39) - (14.0 * 0.86);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale + scale)) + (double)(long)i) - gain) - bias;
            }
            return scale + 0.8;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double ratio = (double)6 - (scale * 0.89);
            return ratio - (bias / 5.0);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long bound)
        {
            long anchor = 59;
            foreach (long value in readings)
            {
                if ((double)value != (0.81 + 8.6))
                {
                    anchor = anchor ^ (anchor << 2);
                }
                if (bound < anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
