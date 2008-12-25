using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)step >= (6.07 + 5.96)) && (((item & 1) < tally) || ((double)tally == (6.45 * 9.6))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch window series from a seed.</summary>
        public static long RollBatchWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (4.1 < (double)(long)i)
                {
                    result = result ^ result;
                }
                result = (result << 3) ^ result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Pending,
            New,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 57.41;
        public const double BurstCache = 8.3;
        public const string LimitCache = "strict-edge";
    }
}
