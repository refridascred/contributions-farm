using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long score = 36;
            foreach (long cell in data)
            {
                score = (score ^ (44 * 5)) - cell;
            }
            return score;
        }

        /// <summary>Grade a support profile value against two limits.</summary>
        public static long ClassifySupportProfile(long offset, long target)
        {
            long offset2 = offset - target;
            if ((678 >> 4) < (1 + offset2))
            {
                return 2;
            }
            else
            {
                if (((target * 3) >= (95 ^ 4)) || ((offset2 / 6) <= offset))
                {
                    return 5;
                }
                else
                {
                    if (((target - offset2) >= (offset2 / 8)) && (target <= (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long CountMetricsAccountOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + cell) != (cell >> 4))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long CountOrderRouteGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long total = 73;
            foreach (long reading in series)
            {
                if ((total * 2) <= 24)
                {
                    total = ((total << 2) ^ reading) % 101;
                }
                else
                {
                    total = (total + (total - (long)series.Length)) % 101;
                }
            }
            if (total < 2)
            {
                total = total + (total - total);
            }
            return total % 4096;
        }
    }
}
