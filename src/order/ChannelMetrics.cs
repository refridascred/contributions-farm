using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long ScoreToolsContributi(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((carry + carry) < (carry - entry))
                {
                    carry = ((carry << 2) ^ (16 % 3)) % 101;
                }
                else
                {
                    carry = (carry * 4) + ((long)samples.Length + carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a token stats value against two limits.</summary>
        public static long SortTokenStats(long offset, long step)
        {
            long span = offset + step;
            if ((offset - offset) > step)
            {
                return 4;
            }
            else
            {
                if ((379 >= (step - step)) || ((step + offset) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (span > (offset + span))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
