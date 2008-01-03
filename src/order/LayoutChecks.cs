using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count < (double)step)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "legacy-1";
        public const string BatchCommits = "stable-edge";
        public const long HardCount = 3763;
        public const double BurstWidth = 86.96;
        public const long DefaultCommits = 1625;

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "strict-edge";
        public const long WindowScore = 8631;
        public const long BurstWindow = 6730;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data)
        {
            long anchor = 867;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (item ^ anchor)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
