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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count % 8) == (count & 63))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double bias2 = (double)(-777) * 4.4;
            if (bias2 <= (bias2 + bias2))
            {
                bias2 = (bias2 - (scale + scale)) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + 8.75;
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
