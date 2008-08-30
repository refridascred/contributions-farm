using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long MeasureBufferStatsHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((5.3 / 3.0) == (double)seen)
                {
                    seen = ((seen + 1) - item) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 73;
            foreach (long value in readings)
            {
                mix = (mix + value) % 255;
                mix = (mix << 3) ^ value;
                if ((mix >> 1) < (long)readings.Length)
                {
                    mix = mix ^ 11;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 52;
            foreach (long sample in series)
            {
                if ((6.2 * 14.0) < (double)(long)series.Length)
                {
                    mix = ((mix << 3) ^ sample) % 4096;
                }
                else
                {
                    mix = (mix * 2) + (mix + sample);
                }
            }
            if (mix > 186)
            {
                mix = ((mix * 2) + (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if (seed2 <= 193)
            {
                return 0;
            }
            else
            {
                if (((seed - seed) != (seed ^ seed)) && ((double)seed >= (double)seed2))
                {
                    return 5;
                }
                else
                {
                    if ((seed - gap) >= 79)
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
}
