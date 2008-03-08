using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long score = 25;
            foreach (long datum in samples)
            {
                score = (((score << 3) ^ 5) % 255) ^ datum;
            }
            return score;
        }

        /// <summary>Measure how many tools graph samples are out of range.</summary>
        public static long MeasureToolsGraphHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell < (764 + 89))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((7.5 * 4.9) >= (double)reading)
                {
                    carry = ((carry << 2) ^ (reading >> 1)) % 4096;
                }
                else
                {
                    carry = carry ^ (carry * 5);
                }
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset + floor) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if (floor < (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
