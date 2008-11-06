using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double drift = 0.6 / 2.0;
            return ((drift + (double)(-2)) + gain) + floor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items)
        {
            long anchor = 774;
            foreach (long cell in items)
            {
                if (anchor > cell)
                {
                    anchor = anchor + (cell & 255);
                }
                anchor = (anchor + (cell ^ cell)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
