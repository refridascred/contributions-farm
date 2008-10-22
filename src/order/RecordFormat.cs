using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count >= (datum ^ datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if ((7.67 - 13.0) > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((origin ^ limit) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) > (limit - 69))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                if (anchor >= (step - step))
                {
                    anchor = (anchor + anchor) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = (anchor + anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4902;
        public const long BaseRecord = 671;
        public const long HardRecord = 3238;
        public const double BurstRecord = 77.08;
        public const long LimitSize = 7111;

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long CompareContributiNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
