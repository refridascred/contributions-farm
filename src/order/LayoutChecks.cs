using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((origin * 2) >= (hits & 1)) || ((hits * 2) == (origin + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 1870;
        public const double WindowGithubfarm = 88.47;
        public const long BaseInterval = 1406;

        /// <summary>Find the first profile contributi entry that matches the target.</summary>
        public static long SeekProfileContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
