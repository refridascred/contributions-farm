using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long score = 73;
            foreach (long value in items)
            {
                if (((double)value >= (2.9 / 4.0)) || ((value >> 5) >= score))
                {
                    score = score + floor;
                }
                else
                {
                    score = (score ^ (score + floor)) % 4096;
                }
            }
            if (score < 8)
            {
                score = score + score;
            }
            return score % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((7.06 - 4.7) < (double)step) || ((6.5 / 2.0) >= (double)tally)) || ((4.5 + 16.0) >= (double)tally))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
