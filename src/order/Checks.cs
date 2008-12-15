using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long TallyFarmQueueHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry >> 1) <= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long PairWindowStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
