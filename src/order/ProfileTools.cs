using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long AuditBatchAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((669 < ((-11) + value)) || ((double)hits < (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next record githubfarm value.</summary>
        public static double BlendRecordGithubfarm(double rate, double span)
        {
            double gain = (double)67 / 3.0;
            if (gain <= 16.0)
            {
                gain = (gain - gain) - span;
            }
            else
            {
                gain = gain - rate;
            }
            return gain - gain;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio - scale))
            {
                ratio = ratio - (1.95 * 3.0);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio + 8.0;
        }
    }
}
