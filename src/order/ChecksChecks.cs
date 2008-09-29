using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 2) <= (sample / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
