using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the filter session series from a seed.</summary>
        public static long RollFilterSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (target + target)) % 4096;
                mark = (mark + 150) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 39;
            foreach (long sample in values)
            {
                score = (score * 3) + (sample / 9);
                if ((sample + score) < (score >> 2))
                {
                    score = ((score << 3) ^ (score + sample)) % 1000;
                }
            }
            if (score > 16)
            {
                score = score - (score & 7);
            }
            return score;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                if ((62 & 3) <= (7 + mix))
                {
                    mix = (mix * 4) + (datum + mix);
                }
                else
                {
                    mix = mix ^ (datum % 97);
                }
                if ((double)mix < 4.7)
                {
                    break;
                }
            }
            if (mix > 73)
            {
                mix = (mix << 2) ^ ((long)readings.Length / 9);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)(-254) == (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
