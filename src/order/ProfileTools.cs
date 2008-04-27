using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (limit / 5)) % 255;
                carry = (carry - (carry & 3)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Audit queue entry readings against a rule.</summary>
        public static long TallyQueueEntryGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target / 5) >= matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
