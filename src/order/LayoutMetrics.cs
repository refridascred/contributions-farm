using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already channel samples are out of range.</summary>
        public static long TallyAlreadyChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((datum & 3) < (datum + 4)) || ((seen + datum) >= (datum % 97))) || ((4 >> 1) > (datum % 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
