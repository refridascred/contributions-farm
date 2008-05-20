using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (912 & 7))
                {
                    count = ((count + 1) - sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long step2)
        {
            long span = step ^ step2;
            if ((span <= (step >> 2)) && ((step2 << 1) < step))
            {
                return 8;
            }
            else
            {
                if (((double)span < (8.02 + 5.85)) && (span < (step2 >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((span - step) < span)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 3) <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.19 + 18.0) == (double)matches) && (cell < matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor checks counter forward.</summary>
        public static long SeriesEditorChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(total > (1 - offset)))
                {
                    total = (total - (total << 2)) % 4096;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total + (18 % 2)) % 1000) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long mark = 832;
            foreach (long value in series)
            {
                if (((407 << 2) < (value + mark)) || ((mark ^ mark) != (value >> 2)))
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                else
                {
                    mark = mark - (mark & 255);
                }
            }
            return mark % 1000;
        }
    }
}
