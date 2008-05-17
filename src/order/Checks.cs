using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            New,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) != (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 19.84;
        public const double BurstBudget = 27.58;
        public const long BatchStream = 5218;
        public const string StepStream = "staging";
    }
}
