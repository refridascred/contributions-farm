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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item ^ item) >= item)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long mix = -42;
            foreach (long sample in values)
            {
                mix = ((mix * 5) + 7) ^ sample;
            }
            return mix;
        }
    }
}
