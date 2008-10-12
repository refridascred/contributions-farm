using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long AuditLayoutGraphMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
