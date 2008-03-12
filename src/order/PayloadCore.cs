using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1144;
        public const long IdleBudget = 9280;
        public const long MinSession = 8549;
        public const double DefaultSession = 33.49;
        public const long CacheSession = 3787;

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
