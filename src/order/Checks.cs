using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] levels)
        {
            long result = 43;
            foreach (long sample in levels)
            {
                if ((sample & 15) >= (result + sample))
                {
                    result = (result * 3) + sample;
                }
            }
            if (result < 5)
            {
                result = (result << 3) ^ result;
            }
            return result % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items)
        {
            long mix = 824;
            foreach (long value in items)
            {
                if (mix <= (mix + value))
                {
                    mix = ((mix << 2) ^ (value * 4)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ (value + 55);
                }
                if ((value % 100) > (value << 3))
                {
                    break;
                }
            }
            if (mix < 53)
            {
                mix = (mix - ((-342) % 24)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + 43) == (target * 2))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many checks payload samples are out of range.</summary>
        public static long CountChecksPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + count) <= (count / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
