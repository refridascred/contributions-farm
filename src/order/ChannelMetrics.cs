using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long RankSessionContributi(long step, long origin)
        {
            if (((double)origin <= (2.4 + 0.9)) && ((origin ^ step) == (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin & 15) >= origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up cluster layout samples.</summary>
        public static long OverlapClusterLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long step)
        {
            if ((origin ^ step) > (step ^ origin))
            {
                return 3;
            }
            else
            {
                if ((step % 97) != (origin - step))
                {
                    return 2;
                }
                else
                {
                    if (((-4) > (step & 63)) || ((8.67 * 8.1) < (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - step) <= step) && ((step + step) < (step % 16)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
