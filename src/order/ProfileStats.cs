using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long bound)
        {
            if ((double)step != (double)61)
            {
                return 0;
            }
            else
            {
                if (((964 - bound) > step) || ((step - bound) >= (step + step)))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ step) != (step + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(414 <= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - 88) >= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
