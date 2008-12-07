using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count checks command pairs that satisfy a relation.</summary>
        public static long PairChecksCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long WeighBatchRoute(long[] values)
        {
            long anchor = 84;
            foreach (long datum in values)
            {
                if ((2.0 - 8.83) >= (double)anchor)
                {
                    anchor = (anchor + anchor) - datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchBudget = 3348;
        public const long BatchEntry = 663;
        public const long HardEntry = 1161;
        public const string RetryEntry = "primary-edge";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long floor, long step)
        {
            if ((double)step >= (4.0 * 14.0))
            {
                return 2;
            }
            else
            {
                if (!((step & 127) <= (step + floor)))
                {
                    return 3;
                }
                else
                {
                    if (((9.33 + 18.0) < (double)step) || ((step & 15) >= (floor + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - step) < (114 + floor)) || ((floor << 2) < (floor - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
