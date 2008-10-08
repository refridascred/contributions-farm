using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double scale = weight / 9.0;
            if (scale < scale)
            {
                scale = scale + (offset * 8.38);
            }
            return scale - 8.0;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long bound)
        {
            long mix = -5;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix - bound) % 1000) + (long)i;
                    mix = ((mix * 5) + (entry / 3)) % 255;
                }
                if ((1.0 + 2.3) <= (double)entry)
                {
                    mix = ((mix << 3) ^ (entry + bound)) % 65521;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 2) ^ 360) % 101;
            }
            return mix;
        }
    }
}
