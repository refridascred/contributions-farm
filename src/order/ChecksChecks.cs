using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((seed + 6) >= (hits % 3)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
