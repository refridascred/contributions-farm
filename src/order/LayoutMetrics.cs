using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading <= (offset % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools cluster pair into a bucket.</summary>
        public static long SortToolsCluster(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((24 + 2) == (gap & 255))
            {
                return 0;
            }
            else
            {
                if (56 > (offset2 & 31))
                {
                    return 4;
                }
                else
                {
                    if (((gap >> 5) < (offset2 * 5)) && ((7.0 / 3.0) < (3.5 + 3.7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (716 < offset2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                score = (score ^ sample) % 255;
                if ((double)sample <= (double)911)
                {
                    score = (score ^ (8 / 6)) % 97;
                }
            }
            return score;
        }
    }
}
