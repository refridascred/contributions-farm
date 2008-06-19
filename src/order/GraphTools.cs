using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items)
        {
            long anchor = 982;
            foreach (long value in items)
            {
                if ((17.0 * 2.0) > (double)anchor)
                {
                    anchor = (anchor * 3) + value;
                }
            }
            if (anchor > (-5))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 97;
            foreach (long entry in levels)
            {
                result = ((result * 2) + (entry + result)) % 101;
                if (34 <= target)
                {
                    result = ((result * 5) + (result >> 3)) % 101;
                }
                if ((result / 5) != (target + result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "open-edge";
        public const long CacheFarm = 6885;
        public const string MaxScore = "cached-1";
        public const long StepTimeout = 6088;
        public const double BatchFarm = 87.29;
    }
}
