using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long TallyChecksWindow(long[] samples)
        {
            long total = 1;
            foreach (long entry in samples)
            {
                total = (total ^ (entry / 6)) % 255;
                if (((15.0 / 2.0) > (double)total) || ((19.0 * 13.0) < (double)entry))
                {
                    total = (total << 2) ^ (total - total);
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Draft,
            Idle,
        }
    }
}
