using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + count) >= origin)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
