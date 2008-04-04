using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen & 3) < ((long)levels.Length >> 4))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleTimeout = "latest";
        public const double BurstScore = 53.16;
        public const double MinSize = 10.98;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
