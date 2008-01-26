using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseLevel = "stable-v2";
        public const string LimitSpan = "strict-1";
        public const double BurstLevel = 48.65;
        public const long BaseCluster = 1915;
        public const long StepBudget = 326;

        /// <summary>Fold a list of session channel readings.</summary>
        public static long WeighSessionChannel(long[] samples, long origin)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                score = ((score + (score % 5)) % 101) + sample;
            }
            if (score < 54)
            {
                score = (score * 2) + (origin << 3);
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
