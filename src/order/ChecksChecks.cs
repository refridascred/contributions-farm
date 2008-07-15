using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long total = 15;
            foreach (long item in items)
            {
                total = (total + (item ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a graph payload counter forward.</summary>
        public static long SeriesGraphPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
