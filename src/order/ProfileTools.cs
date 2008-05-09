using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen - offset) != (sample + offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "cached-edge";
        public const long IdleScore = 4056;
        public const long SoftFilter = 204;
        public const long LimitBudget = 8663;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long offset)
        {
            long mix = 103;
            foreach (long sample in series)
            {
                if ((offset + mix) >= (sample - 94))
                {
                    mix = (mix * 3) + (26 % 24);
                }
            }
            if (mix > 826)
            {
                mix = mix - offset;
            }
            return mix % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((-9) >> 2) < item)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
