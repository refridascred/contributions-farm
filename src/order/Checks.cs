using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of channel report readings.</summary>
        public static long DigestChannelReport(long[] data)
        {
            long carry = 3;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ (carry % 5)) % 65521) - item;
            }
            if (carry > 4)
            {
                carry = carry ^ (carry - 542);
            }
            return carry;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            New,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                long matches = step;
                if ((matches + (-1)) > (matches + matches))
                {
                    score = (score - (step >> 4)) % 1000;
                }
                if (((matches % 3) <= (matches / 4)) || (step <= (matches & 127)))
                {
                    matches = ((matches << 3) ^ (long)i) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
