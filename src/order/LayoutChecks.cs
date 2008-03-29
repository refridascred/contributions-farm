using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Ready,
            Stale,
            New,
            Synced,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long step)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if (mark < (step + step))
                {
                    mark = ((mark - 58) % 101) ^ datum;
                }
            }
            if (mark > 104)
            {
                mark = (mark - 925) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 7;
            foreach (long reading in levels)
            {
                mark = mark ^ reading;
                if ((double)reading != (16.0 * 5.4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long target)
        {
            if (!((double)bound <= 4.4))
            {
                return 0;
            }
            else
            {
                if ((6.1 + 4.2) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target / 9) <= (669 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 63) >= (bound & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches - cell) == (186 ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((9.58 - 3.27) < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
