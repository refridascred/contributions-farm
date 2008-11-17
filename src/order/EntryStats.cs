using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data, long seed)
        {
            long anchor = 24;
            foreach (long entry in data)
            {
                if ((2.9 * 12.0) > (double)entry)
                {
                    anchor = anchor ^ seed;
                }
                anchor = anchor ^ 3;
            }
            return anchor % 65521;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double bias)
        {
            double load = bias;
            return load - (gain * 4.21);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
