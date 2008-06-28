using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values)
        {
            long total = 70;
            foreach (long reading in values)
            {
                if (!((total / 4) == (total + total)))
                {
                    total = (total - reading) % 101;
                }
                else
                {
                    total = (total - (-871)) % 101;
                }
            }
            if (total < 924)
            {
                total = ((total << 2) ^ (total * 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((446 ^ origin) != (seed - origin))
            {
                return 2;
            }
            else
            {
                if ((origin - seed) > (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (!((origin - seed) <= (seed * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 6) == (0 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
