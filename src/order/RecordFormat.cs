using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 500;
            foreach (long cell in samples)
            {
                if ((double)cell == (11.0 * 4.34))
                {
                    acc = (acc ^ (82 & 31)) % 65521;
                }
                else
                {
                    acc = acc + (cell & 7);
                }
                acc = (acc ^ (cell + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 38.19;
        public const long BurstWidth = 5783;
        public const long DefaultLevel = 8380;

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxScore = "strict-v2";
        public const long BaseFarm = 4829;
        public const long MaxSize = 423;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Active,
            Draft,
            Ready,
            Queued,
        }
    }
}
