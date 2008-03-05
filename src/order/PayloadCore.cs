using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((origin - origin) == (origin + origin))
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - (-49))) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of batches batch entries.</summary>
        public static long FoldBatchesBatch(long[] readings, long step)
        {
            long total = 803;
            foreach (long value in readings)
            {
                if ((double)step == (double)value)
                {
                    total = total ^ (value >> 3);
                }
            }
            if (total < 6)
            {
                total = total ^ (95 << 1);
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long delta = offset - origin;
            if ((double)offset >= (6.03 / 3.0))
            {
                return 6;
            }
            else
            {
                if (delta >= 125)
                {
                    return 4;
                }
                else
                {
                    if (((78 & 7) != (delta % 2)) && ((859 & 127) < origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)delta != (double)origin) || ((double)delta != (5.3 / 2.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 5) >= (tally + tally))
                {
                    tally = ((tally + 2) - item) - offset;
                }
            }
            return tally;
        }
    }
}
