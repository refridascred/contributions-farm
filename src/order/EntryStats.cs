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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstTimeout = 5841;
        public const long BaseMetrics = 6867;
        public const long LimitMetrics = 4595;
        public const long BaseBudget = 8749;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 9320;
        public const string SoftDepth = "alpha";
        public const long DefaultTools = 7147;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
