using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias)
            {
                bias3 = bias3 - (bias * 7.0);
            }
            else
            {
                bias3 = bias3 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias3 * 14.0)) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 76;
            foreach (long value in data)
            {
                anchor = ((anchor * 2) + (anchor + value)) % 97;
            }
            if (anchor < 5)
            {
                anchor = (anchor - (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Failed,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit < (3.2 - 7.7))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
