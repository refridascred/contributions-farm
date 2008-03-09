using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                long delta = limit ^ score;
                if (((long)i ^ delta) >= 4)
                {
                    delta = ((delta * 3) + (limit + limit)) % 4096;
                    score = (score + delta) % 65521;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i != (6.9 - 7.22))
                {
                    break;
                }
                else
                {
                    carry = (carry + ((long)i / 7)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
