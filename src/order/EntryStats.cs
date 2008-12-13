using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = ((carry * 2) + (offset + cell)) % 4096;
                carry = carry + cell;
                carry = (carry + offset) % 1000;
            }
            if (carry < 19)
            {
                carry = carry + (carry * 3);
            }
            return carry % 97;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] samples, long bound)
        {
            long total = 19;
            foreach (long value in samples)
            {
                total = total ^ value;
                total = ((total * 3) + (bound ^ value)) % 65521;
                if (!((value * 4) == (value << 1)))
                {
                    total = (total << 2) ^ (value ^ bound);
                }
            }
            if (total > 880)
            {
                total = ((total * 4) + (long)samples.Length) % 1000;
            }
            return total % 97;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long seed)
        {
            if (target <= 152)
            {
                return 4;
            }
            else
            {
                if ((2.5 + 8.5) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
