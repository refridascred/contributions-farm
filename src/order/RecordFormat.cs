using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate farm record readings against a bound.</summary>
        public static bool CheckFarmRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((offset ^ offset) == ((-39) % 12))
            {
                return 6;
            }
            else
            {
                if ((9.28 / 9.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (1.0 - 2.05))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long offset)
        {
            long anchor = 158;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor - (-8)) % 255) + (long)i;
                }
                anchor = anchor ^ (1 + sample);
                if ((double)sample < 9.1)
                {
                    anchor = (anchor + (offset + offset)) % 65521;
                }
                if (((anchor - offset) <= (sample * 2)) && ((11.0 + 3.4) == (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 9102;
        public const long HardContext = 5330;
        public const long SoftContext = 2060;
        public const long CacheSpan = 4487;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 1) >= (item >> 5))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
