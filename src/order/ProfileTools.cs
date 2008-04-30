using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length != (offset << 3))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix - (mix ^ mix)) % 1000) + reading;
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 648;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (item + item)) % 65521;
            }
            if (carry > 63)
            {
                carry = carry ^ (882 * 4);
            }
            return carry;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
