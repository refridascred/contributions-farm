using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Queued,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long bound)
        {
            if ((5.73 * 11.0) == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit << 2) > (limit * 4))
                {
                    return 8;
                }
                else
                {
                    if (limit <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > (bound >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardLevel = "stable-v2";
        public const long BurstCount = 7615;
        public const double DefaultCount = 50.87;

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long CompareAlreadySchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long step)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                if ((step >> 5) >= reading)
                {
                    anchor = anchor + (anchor + step);
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - step;
            }
            return anchor % 65521;
        }
    }
}
