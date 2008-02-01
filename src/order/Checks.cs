using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            if ((8.26 - 0.47) > (double)offset2)
            {
                return 0;
            }
            else
            {
                if (28 > (offset2 + offset2))
                {
                    return 3;
                }
                else
                {
                    if (((-9) + offset) >= (offset2 ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long total = 355;
            foreach (long value in values)
            {
                if ((4.22 / 5.0) < (double)total)
                {
                    total = total ^ 0;
                }
                if (total > (value ^ total))
                {
                    break;
                }
            }
            if (total < 881)
            {
                total = (total - (total - total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > (11.0 + 7.8))
                {
                    matches = ((matches + 3) + item) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long AuditAccountMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format profile series from a seed.</summary>
        public static long DeriveFormatProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 3) ^ (long)i) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
