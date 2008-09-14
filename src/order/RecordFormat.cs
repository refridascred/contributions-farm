using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample <= seen) || ((53 << 1) < (sample - (-8))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long offset)
        {
            if ((origin % 24) > origin)
            {
                return 7;
            }
            else
            {
                if (offset < (243 ^ offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "stable-edge";
        public const long WindowBuffer = 7558;
        public const long RetryBuffer = 6001;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5078;
        public const string MaxToken = "standard";
        public const long WindowToken = 4648;
        public const string RetryScore = "cached";
        public const long MinWidth = 3183;
    }
}
