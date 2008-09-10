using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long floor)
        {
            if ((floor & 31) > floor)
            {
                return 4;
            }
            else
            {
                if (((double)floor >= (16.0 - 4.0)) && ((double)target <= (double)458))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool ValidateNotesBatchesBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cluster stream value against two limits.</summary>
        public static long ClassifyClusterStream(long target, long seed)
        {
            if ((double)(-113) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((seed & 3) >= (seed + target))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 657) > (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (origin * 3))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
