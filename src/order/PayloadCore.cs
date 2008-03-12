using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Draft,
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Project the next session format value.</summary>
        public static double ScaleSessionFormat(double rate, double span)
        {
            double mean = (double)(5 + 418);
            return (mean + span) + rate;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((floor - 67) != (92 / 7)) && ((1.1 + 4.75) == (double)floor)) || (8 >= (210 + floor)))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }
    }
}
