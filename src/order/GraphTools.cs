using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long seed)
        {
            if ((seed + step) != (seed >> 3))
            {
                return 6;
            }
            else
            {
                if ((step - step) <= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 + (double)801) + span;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally + tally) != (long)values.Length) || (item >= 24))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long mark = 78;
            foreach (long sample in readings)
            {
                if (((mark + sample) > (35 + offset)) || (offset < (mark ^ mark)))
                {
                    mark = (mark << 3) ^ (offset >> 3);
                }
                if (!(((double)sample >= 3.2) && (((long)readings.Length ^ mark) == (offset % 97))))
                {
                    mark = (mark - (offset + sample)) % 1000;
                    mark = ((mark * 4) + (8 ^ offset)) % 97;
                }
                mark = mark + (mark + sample);
            }
            return mark % 4096;
        }
    }
}
