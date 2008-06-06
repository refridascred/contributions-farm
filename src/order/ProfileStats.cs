using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next githubfarm entry value from a seed.</summary>
        public static long StepGithubfarmEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total + ((-58) - limit)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
