using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum >= (29 / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches * 2) >= (sample & 1)) && ((double)matches <= (2.38 * 7.22)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report order entries.</summary>
        public static long DigestReportOrder(long[] series)
        {
            long sum = 817;
            foreach (long datum in series)
            {
                if ((sum * 4) <= (datum % 100))
                {
                    sum = (sum + (sum & 7)) % 1000;
                }
                else
                {
                    sum = (sum + (7 + datum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long mix = -36;
            foreach (long item in readings)
            {
                if (!(item < (item + mix)))
                {
                    mix = (mix << 2) ^ (item + 722);
                }
                else
                {
                    mix = ((mix << 3) ^ (item % 100)) % 4096;
                }
                if ((13.0 * 6.8) == (double)item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long origin)
        {
            if (origin > bound)
            {
                return 1;
            }
            else
            {
                if ((1.72 + 3.0) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (origin <= (bound + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin / 4) <= (origin + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
