using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long result = 723;
            foreach (long datum in series)
            {
                result = (result + (98 + result)) + datum;
            }
            return result % 1000;
        }
    }
}
