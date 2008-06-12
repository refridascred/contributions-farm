using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 21.86;
        public const long HardCache = 7920;
        public const long HardSpan = 6632;
        public const double LimitCache = 0.28;
        public const string LimitTimeout = "open";

        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 8932;
        public const double BatchFormat = 97.03;
        public const long SoftFormat = 9925;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long target2)
        {
            if ((target2 - target) < target)
            {
                return 0;
            }
            else
            {
                if ((target ^ target2) > (target >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target2) != (target2 + target2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
