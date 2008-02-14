using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long MeasureBatchSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (datum >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long CombineProfileBatches(long[] series, long floor)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + (value ^ floor)) % 255;
                if ((3 % 7) < value)
                {
                    break;
                }
            }
            if (mark > (-87))
            {
                mark = (mark - 79) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Locked,
            Active,
            New,
            Closed,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long seed)
        {
            long sum = 12;
            foreach (long datum in samples)
            {
                sum = (sum - (sum + seed)) % 97;
                sum = ((sum << 2) ^ ((-59) + datum)) % 97;
                sum = ((sum << 2) ^ (seed - datum)) % 4096;
                if (datum <= (sum << 3))
                {
                    break;
                }
            }
            if (sum < (-114))
            {
                sum = (sum ^ (seed * 4)) % 65521;
            }
            return sum;
        }
    }
}
