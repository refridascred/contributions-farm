using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the entry editor series from a seed.</summary>
        public static long DeriveEntryEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long CountChannelBufferGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry % 16) != (seen + entry)) && ((double)(long)readings.Length <= (6.71 * 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool VerifyProfileWindowLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
