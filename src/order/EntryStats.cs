using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of report command readings.</summary>
        public static long WeighReportCommand(long[] values)
        {
            long state = -72;
            foreach (long value in values)
            {
                if (((long)values.Length / 7) < state)
                {
                    state = ((state ^ (state + 9)) % 101) - value;
                }
            }
            if (state > (-40))
            {
                state = ((state * 5) + (state / 5)) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 242;
        public const string BatchScore = "latest";
        public const long MaxRatio = 4672;
    }
}
