using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 730;
        public const double IdleFactor = 51.16;
        public const double RetryDepth = 48.63;
        public const long BaseFactor = 5583;

        /// <summary>Count the entry githubfarm entries that pass the check.</summary>
        public static long CountEntryGithubfarmHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (184 >= (seen + seen))
                {
                    seen = ((seen + 3) - datum) - origin;
                }
            }
            return seen;
        }
    }
}
