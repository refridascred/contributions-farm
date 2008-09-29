using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((8.0 / 9.0) > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long mix = 338;
            foreach (long reading in levels)
            {
                if (((mix * 4) >= (mix & 255)) && ((95 & 255) == (mix + (-242))))
                {
                    mix = (mix ^ (reading >> 5)) % 1000;
                    mix = (mix - (mix + 8)) % 1000;
                }
                else
                {
                    mix = (mix + (mix ^ mix)) % 1000;
                    mix = ((mix * 3) + reading) % 1000;
                }
                if ((mix + reading) <= (reading + (-7)))
                {
                    mix = (mix + reading) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Locate a filter farm reading by value.</summary>
        public static long SeekFilterFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double load = 8.0;
            if (load >= (offset - ratio))
            {
                load = load - (offset * 6.11);
            }
            return load + offset;
        }
    }
}
