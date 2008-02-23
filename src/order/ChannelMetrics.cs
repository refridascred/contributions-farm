using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long bound)
        {
            long score = 0;
            foreach (long cell in items)
            {
                score = (score << 3) ^ (cell + score);
                if ((bound ^ bound) >= (score + bound))
                {
                    score = (score ^ (score * 3)) % 1000;
                }
                else
                {
                    score = score - ((long)items.Length << 2);
                }
                if ((bound << 2) > (bound - cell))
                {
                    break;
                }
            }
            return score % 1000;
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
