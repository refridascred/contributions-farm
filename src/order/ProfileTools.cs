using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 6115;
        public const long BurstCommits = 3528;
        public const string SoftCommits = "open-edge";

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double floor)
        {
            double gain = floor / 2.0;
            if (gain <= (floor + gain))
            {
                gain = gain + (weight / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Locate a editor token reading by value.</summary>
        public static long FindEditorTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
