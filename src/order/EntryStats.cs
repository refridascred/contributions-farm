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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
