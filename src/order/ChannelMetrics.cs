using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum + 7) >= (limit + limit)) && !((double)datum > (8.7 + 9.32)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if (((double)mix > (4.7 + 8.76)) || ((double)reading != (3.0 / 2.0)))
                {
                    mix = ((mix * 5) + reading) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + reading);
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank editor commits input into a small class.</summary>
        public static long GradeEditorCommits(long step, long bound)
        {
            if ((step % 60) >= step)
            {
                return 0;
            }
            else
            {
                if (((step << 2) >= step) || ((step % 64) >= step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
