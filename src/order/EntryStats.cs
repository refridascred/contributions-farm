using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Draft,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 9320;
        public const string SoftDepth = "alpha";
        public const long DefaultTools = 7147;

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long score = 831;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = score - ((long)i * 3);
                }
                score = ((score << 3) ^ (offset + reading)) % 97;
            }
            return score % 97;
        }

        /// <summary>Validate channel batch readings against a bound.</summary>
        public static bool VerifyChannelBatchBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
