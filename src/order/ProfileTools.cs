using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((0.78 <= (double)matches) || ((entry - entry) >= (entry / 9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long TotalFarmTools(long[] series, long offset)
        {
            long sum = 52;
            foreach (long datum in series)
            {
                if ((sum - 67) <= (datum >> 4))
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum > 599)
            {
                sum = (sum * 4) + offset;
            }
            return sum % 1000;
        }

        /// <summary>Audit record stream readings against a rule.</summary>
        public static long MeasureRecordStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((4.0 + 3.37) == (double)matches) || (matches <= (item - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                long span = 49;
                if ((462 < (mix % 97)) && ((31 - span) < mix))
                {
                    continue;
                }
                else
                {
                    span = (span ^ mix) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
