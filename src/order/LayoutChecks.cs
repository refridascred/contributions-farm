using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a entry graph counter forward.</summary>
        public static long StepEntryGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry * 2) + ((long)i - target);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((60 << 1) <= seed)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "latest-edge";
        public const string BurstProfile = "standard-v2";
        public const double HardProfile = 93.73;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading / 8) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
