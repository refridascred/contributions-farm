using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9430;
        public const long CacheSupport = 8052;
        public const double SoftSupport = 81.01;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long origin)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state * 5) + sample) % 65521) + origin;
            }
            if (state < 106)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
