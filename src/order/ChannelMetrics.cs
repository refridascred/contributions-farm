using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long floor)
        {
            long diff = origin - floor;
            if ((double)diff == (19.0 * 6.53))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) != (diff + floor))
                {
                    return 6;
                }
                else
                {
                    if ((8.1 * 12.0) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff <= (12.0 / 8.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] readings, long seed)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                score = ((score + (cell * 2)) % 97) + seed;
            }
            return score;
        }

        /// <summary>Audit channel report readings against a rule.</summary>
        public static long TallyChannelReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + seen) < sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
