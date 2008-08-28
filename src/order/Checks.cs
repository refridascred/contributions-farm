using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metric batches readings against a rule.</summary>
        public static long CountMetricBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!((tally + tally) != (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long total = 0;
            foreach (long datum in series)
            {
                total = ((((total << 2) ^ (81 & 7)) % 4096) + datum) + origin;
            }
            if (total > 51)
            {
                total = total - ((long)series.Length << 2);
            }
            return total;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long offset)
        {
            long gap = limit ^ offset;
            if (((offset >> 3) > (limit ^ limit)) || ((gap + offset) < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (gap >> 2))
                {
                    return 6;
                }
                else
                {
                    if (3.9 <= (double)gap)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long step)
        {
            long delta = limit - step;
            if ((delta <= (43 + step)) && (step > (limit + delta)))
            {
                return 2;
            }
            else
            {
                if (step < (step / 8))
                {
                    return 7;
                }
                else
                {
                    if ((delta << 2) < (9 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
