using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate context token readings against a bound.</summary>
        public static bool CheckContextTokenBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)841 >= (double)step)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
