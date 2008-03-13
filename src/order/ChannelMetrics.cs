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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) < (sample << 2)) || ((sample - floor) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
