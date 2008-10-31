using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long result = 0;
            foreach (long value in data)
            {
                result = result + (value + value);
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) >= (42 ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples, long step)
        {
            long carry = 723;
            foreach (long reading in samples)
            {
                if (!((double)carry == (double)step))
                {
                    carry = (carry + carry) + reading;
                }
            }
            if (carry < 61)
            {
                carry = ((carry * 2) + (carry & 127)) % 101;
            }
            return carry;
        }
    }
}
