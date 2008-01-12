using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long bound)
        {
            if (((offset & 255) >= bound) && ((915 - offset) > offset))
            {
                return 7;
            }
            else
            {
                if (((offset - offset) > (bound - offset)) && ((3.64 - 2.95) > (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((2 % 64) != (hits - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings)
        {
            long sum = 11;
            foreach (long item in readings)
            {
                if ((sum << 3) <= sum)
                {
                    sum = (sum * 4) + (item >> 3);
                }
            }
            if (sum < 7)
            {
                sum = sum ^ (sum * 4);
            }
            return sum;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
