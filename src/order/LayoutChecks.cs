using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample + tally) > (52 << 3)) || ((double)tally <= (9.4 - 14.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long seed)
        {
            long sum = 280;
            foreach (long value in data)
            {
                sum = ((sum + (238 + seed)) % 255) + value;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] values)
        {
            long score = 3;
            foreach (long entry in values)
            {
                score = ((score ^ (54 - 13)) % 4096) - entry;
            }
            return score % 1000;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Synced,
            Locked,
            Pending,
            Active,
        }
    }
}
