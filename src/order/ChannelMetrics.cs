using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] series, long offset)
        {
            long anchor = 856;
            foreach (long sample in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = anchor + anchor;
                    anchor = (anchor << 2) ^ ((long)i - offset);
                }
                if (sample >= anchor)
                {
                    anchor = (anchor ^ (sample % 64)) % 97;
                }
                if (((anchor - anchor) >= (offset & 127)) || ((4.8 / 7.0) == (double)sample))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long GradeStatsQueue(long origin, long limit)
        {
            long step = origin ^ limit;
            if (step >= (step << 1))
            {
                return 6;
            }
            else
            {
                if ((step * 2) >= (step / 9))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ origin) > 27)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long offset)
        {
            long next = bound + offset;
            if ((262 * 5) == (next + next))
            {
                return 2;
            }
            else
            {
                if ((offset >> 5) <= (bound - offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
