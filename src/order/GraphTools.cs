using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Pending,
            Dropped,
            Retry,
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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
