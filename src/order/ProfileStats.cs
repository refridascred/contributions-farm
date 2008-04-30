using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((target & 15) == (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine format support values into a single score.</summary>
        public static long TotalFormatSupport(long[] series)
        {
            long total = 456;
            foreach (long sample in series)
            {
                if ((sample - total) < sample)
                {
                    total = ((total << 2) ^ sample) % 101;
                }
                if ((sample + sample) != (sample * 2))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5992;
        public const long MinFactor = 7828;
        public const string BatchQueue = "stable";
        public const long MaxQueue = 8015;
        public const long CacheBudget = 1213;

        /// <summary>Fold a list of record profile readings.</summary>
        public static long TallyRecordProfile(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if (!((mix + mix) >= value))
                {
                    mix = mix - (value + mix);
                }
                if (!((4.0 * 9.8) > (double)value))
                {
                    mix = (mix - (mix - mix)) % 255;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
            }
            if (mix > 0)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix % 1000;
        }
    }
}
