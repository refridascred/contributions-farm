using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample % 8) > (sample ^ (long)data.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinSize = 20.49;
        public const double DefaultCount = 89.69;
        public const long BatchCount = 5893;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ entry) % 101;
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (87 <= sample)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
