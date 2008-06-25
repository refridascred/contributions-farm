using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every graph contributi entry stays within the limit.</summary>
        public static bool ValidateGraphContributiBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Idle,
            Stale,
            Done,
        }
    }
}
