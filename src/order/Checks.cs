using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((1.6 / 2.0) < (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "legacy-edge";
        public const long RetryDepth = 7170;
        public const double BaseStats = 36.47;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Dropped,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Grade a notes contributi value against two limits.</summary>
        public static long BucketNotesContributi(long step, long limit)
        {
            long edge = step + limit;
            if ((double)edge >= (3.49 / 4.0))
            {
                return 6;
            }
            else
            {
                if (limit <= (697 - 3))
                {
                    return 2;
                }
                else
                {
                    if (edge <= (limit + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
