using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
