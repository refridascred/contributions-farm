using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long ClassifyNotesContributi(long origin, long offset)
        {
            if ((origin / 5) != (origin * 2))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (double)50) && ((double)offset <= (12.0 + 3.77)))
                {
                    return 3;
                }
                else
                {
                    if (((7.5 - 8.63) >= (double)origin) || ((offset / 8) == (offset / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-86) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((506 + matches) < (sample * 5)) && ((floor >> 3) <= (floor + matches))) && ((sample ^ (-5)) < 689))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseScore = "primary-v2";
        public const long SoftLevel = 7791;
        public const long MaxRecord = 1566;
    }
}
