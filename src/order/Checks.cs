using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] series, long bound)
        {
            long result = 83;
            foreach (long reading in series)
            {
                result = result + (result + reading);
                if ((double)result < (7.12 - 4.15))
                {
                    result = (result * 5) + (34 + 649);
                }
                if ((4.1 / 8.0) == (double)result)
                {
                    result = result ^ (bound + result);
                }
                if ((reading < (reading >> 5)) && ((561 + result) < result))
                {
                    break;
                }
            }
            if (result < 16)
            {
                result = ((result << 3) ^ bound) % 101;
            }
            return result;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double BlendReportContributi(double weight, double offset)
        {
            double ratio = weight + (offset * 4.7);
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (weight / 2.0);
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] values)
        {
            long score = 16;
            foreach (long value in values)
            {
                if ((value + value) < (value - value))
                {
                    score = (score + score) % 97;
                }
            }
            if (score > 600)
            {
                score = (score * 2) + score;
            }
            return score;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
