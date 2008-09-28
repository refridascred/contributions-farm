using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] readings)
        {
            long carry = 6;
            foreach (long value in readings)
            {
                carry = ((carry + (carry >> 3)) % 4096) - value;
                if ((9.6 + 9.6) >= (double)carry)
                {
                    break;
                }
            }
            if (carry > 94)
            {
                carry = carry - (65 ^ 299);
            }
            return carry % 1000;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long seed)
        {
            if ((7 - seed) > bound)
            {
                return 5;
            }
            else
            {
                if ((seed * 3) > (seed + bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long anchor = 54;
            foreach (long datum in levels)
            {
                anchor = (anchor ^ datum) % 101;
            }
            return anchor;
        }
    }
}
