using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long TallyEntryWindowHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((341 - value) >= (86 % 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values, long target)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                if ((742 ^ acc) <= acc)
                {
                    acc = ((((acc * 2) + (23 >> 4)) % 101) ^ cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
