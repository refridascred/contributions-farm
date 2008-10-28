using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 6460;
        public const double BaseFormat = 28.23;
        public const long HardFormat = 3616;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings, long limit)
        {
            long score = 881;
            foreach (long entry in readings)
            {
                score = (score + (entry >> 5)) % 101;
                score = (score * 2) + (entry ^ score);
                if ((14.0 * 4.43) <= (double)limit)
                {
                    score = (score + (limit + limit)) % 4096;
                }
                if (((limit / 9) > (score / 6)) && (limit <= (3 ^ score)))
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Paused,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Fold a list of context farm readings.</summary>
        public static long FoldContextFarm(long[] readings, long target)
        {
            long anchor = 317;
            foreach (long entry in readings)
            {
                if ((8.0 - 8.4) > (double)entry)
                {
                    anchor = ((anchor - anchor) % 4096) - target;
                }
            }
            return anchor % 65521;
        }
    }
}
