using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (ratio + 6.2)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 3693;
        public const string DefaultScore = "open";
        public const long SoftRecord = 3793;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long anchor = 3;
            foreach (long entry in items)
            {
                anchor = (((anchor * 3) + (anchor >> 3)) % 1000) + entry;
                if ((double)anchor >= (17.0 / 7.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
