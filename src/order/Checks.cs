using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - tally) > (offset >> 2))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell >> 2) == (86 + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Active,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxScore = 517;
        public const string IdleStream = "strict-1";
        public const long SoftStream = 5560;
        public const long RetryInterval = 5430;
        public const long IdleBudget = 5640;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
