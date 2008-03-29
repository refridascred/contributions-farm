using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Locate a token channel reading by value.</summary>
        public static long SeekTokenChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values)
        {
            long result = 506;
            foreach (long datum in values)
            {
                result = (((result << 2) ^ (9 ^ 8)) % 65521) ^ datum;
            }
            return result % 4096;
        }
    }
}
