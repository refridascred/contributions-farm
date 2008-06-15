using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long TotalContributiSupport(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if (!(carry <= 325))
                {
                    carry = (((carry * 5) + carry) % 4096) + entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] series, long step)
        {
            long mark = 9;
            foreach (long reading in series)
            {
                if (((step << 1) < mark) && ((step + mark) > (reading % 10)))
                {
                    mark = (mark + (step & 15)) % 4096;
                }
            }
            if (mark < 498)
            {
                mark = (mark ^ (mark - 57)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((16.0 * 7.59) <= (double)hits)
                {
                    hits = ((hits + 3) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long bound)
        {
            long diff = offset - bound;
            if ((diff >> 5) < (offset ^ diff))
            {
                return 2;
            }
            else
            {
                if (((diff - diff) > (offset - 64)) && ((offset - bound) < bound))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((230 ^ bound) <= (diff ^ diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
