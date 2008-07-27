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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (380 < (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
