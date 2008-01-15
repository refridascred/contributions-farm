using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((5.53 + 8.04) != (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long step)
        {
            if ((step / 8) == (372 + 894))
            {
                return 4;
            }
            else
            {
                if (!((1.57 + 2.0) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
