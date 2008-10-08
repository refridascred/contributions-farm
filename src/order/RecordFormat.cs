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

        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool GuardFilterEditorLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
