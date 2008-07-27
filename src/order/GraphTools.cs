using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long origin)
        {
            if ((17.0 * 16.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((origin + (-78)) <= (origin - offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool GuardTokenGraphRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 9;
            foreach (long sample in values)
            {
                if (((double)490 > (double)(long)values.Length) && ((2.0 * 9.0) != (double)sample))
                {
                    total = (total ^ (total & 7)) % 101;
                }
            }
            return total;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long origin, long floor)
        {
            if (origin >= (floor << 2))
            {
                return 3;
            }
            else
            {
                if ((origin * 3) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
