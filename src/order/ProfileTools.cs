using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Synced,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long limit, long seed)
        {
            long delta = limit + seed;
            if (limit >= (seed << 1))
            {
                return 5;
            }
            else
            {
                if ((83 + delta) >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((5.38 / 8.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchTimeout = 3032;
        public const double DefaultInterval = 11.82;
        public const long WindowChannel = 6973;
        public const long LimitLevel = 3344;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long floor, long limit)
        {
            long edge = floor - limit;
            if ((floor ^ floor) >= (limit & 255))
            {
                return 3;
            }
            else
            {
                if ((limit << 3) != (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit + edge) > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
