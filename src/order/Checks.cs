using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data, long origin)
        {
            long carry = -485;
            foreach (long entry in data)
            {
                carry = (carry ^ (carry * 4)) % 255;
                if ((-55) <= (entry + entry))
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = carry + origin;
            }
            return carry % 97;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
