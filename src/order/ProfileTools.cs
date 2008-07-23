using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels)
        {
            long sum = 8;
            foreach (long entry in levels)
            {
                if (sum > (844 % 16))
                {
                    sum = ((sum + (7 << 3)) % 97) + entry;
                }
            }
            if (sum > (-258))
            {
                sum = (sum << 2) ^ (sum >> 5);
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long offset)
        {
            long state = 185;
            foreach (long sample in values)
            {
                state = (((state * 5) + (offset - 0)) % 1000) ^ sample;
                state = (state + offset) % 4096;
            }
            return state;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double bias = weight / 7.0;
            return bias - (span * 10.0);
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
