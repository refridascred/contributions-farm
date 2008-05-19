using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5933;
        public const string MaxNotes = "latest-v2";
        public const long IdleNotes = 9700;
        public const long MaxBudget = 1818;
        public const string RetrySpan = "local-v2";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                total = (total + (total - total)) - datum;
            }
            return total % 97;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long step)
        {
            long diff = floor ^ step;
            if (14.0 <= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((step + diff) <= (step & 127))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 824;
            foreach (long sample in readings)
            {
                if ((total - sample) < (sample << 1))
                {
                    continue;
                }
                else
                {
                    total = (total + (sample ^ total)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    long span = (18 + sample) - ((long)readings.Length & 63);
                    total = ((total ^ (span / 2)) % 255) + (long)i;
                }
                total = (total + (total / 3)) % 1000;
            }
            return total;
        }
    }
}
