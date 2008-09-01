using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long limit)
        {
            long acc = 67;
            foreach (long entry in items)
            {
                if (!(acc > (13 + limit)))
                {
                    acc = acc + entry;
                    acc = acc ^ ((-45) + (-844));
                }
                else
                {
                    acc = (acc + (entry - entry)) % 101;
                }
                if ((60 ^ entry) == (entry - entry))
                {
                    acc = ((acc * 4) + (acc % 8)) % 255;
                    acc = (acc + (acc + entry)) % 1000;
                }
                acc = (acc << 3) ^ (acc ^ acc);
                if ((limit - entry) <= entry)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long result = -731;
            foreach (long item in readings)
            {
                result = (result ^ (989 << 1)) % 65521;
                if (((result - result) < (707 & 63)) && (item < (232 + item)))
                {
                    break;
                }
            }
            if (result < 490)
            {
                result = (result - (result * 4)) % 4096;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 3999;
        public const double LimitTimeout = 35.15;
        public const long CacheProfile = 789;
        public const double MaxDepth = 5.89;
        public const string LimitProfile = "standard-1";

        /// <summary>Grade a report stream value against two limits.</summary>
        public static long ClassifyReportStream(long step, long target)
        {
            if (((double)step <= 1.9) && (5.8 >= (double)target))
            {
                return 0;
            }
            else
            {
                if ((step / 7) > 4)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
