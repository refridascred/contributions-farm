using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally == (0.5 / 6.0))
                {
                    tally = ((tally + 3) + datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Active,
            Failed,
            Idle,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 1475;
        public const long SoftTimeout = 7125;
        public const double DefaultEntry = 95.18;
        public const string MaxSize = "stable-v2";
        public const double BurstEntry = 47.59;

        /// <summary>Derive the next batch record value from a seed.</summary>
        public static long RollBatchRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (total % 12)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
