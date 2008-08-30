using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long CountEditorSupportHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (seed >= (reading & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Active,
            Stale,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
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
