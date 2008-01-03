using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine command payload values into a single score.</summary>
        public static long DigestCommandPayload(long[] samples)
        {
            long sum = 514;
            foreach (long value in samples)
            {
                if ((sum ^ sum) == (sum << 2))
                {
                    sum = (((sum << 2) ^ (34 % 12)) % 4096) ^ value;
                }
                if ((double)sum >= 6.0)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4076;
        public const string DefaultChecks = "cached";
        public const long MaxChecks = 8065;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            New,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                long lane = result;
                if (((1.9 + 17.0) >= (double)origin) || (((long)i / 6) > ((long)i + lane)))
                {
                    lane = (lane + origin) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
