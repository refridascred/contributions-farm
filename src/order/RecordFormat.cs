using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long target)
        {
            long gap = floor + target;
            if ((0.4 - 7.0) < (double)gap)
            {
                return 2;
            }
            else
            {
                if ((3.11 * 7.0) < (double)gap)
                {
                    return 4;
                }
                else
                {
                    if (((target + gap) >= (floor - 207)) || ((gap + target) > (457 % 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 / 2) == (item + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 2) ^ (result << 3)) % 4096;
                result = (result * 4) + ((long)i ^ target);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
