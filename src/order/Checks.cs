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

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((8.0 + 14.0) > (double)reading)
                {
                    continue;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score - 195)) % 255) + (long)i;
                    score = (score - (reading ^ 238)) % 255;
                }
                if ((double)reading != (7.6 / 3.0))
                {
                    score = (score - (score + score)) % 101;
                }
            }
            return score % 1000;
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
