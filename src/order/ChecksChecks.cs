using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every filter tools entry stays within the limit.</summary>
        public static bool ValidateFilterToolsLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings, long target)
        {
            long score = 661;
            foreach (long item in readings)
            {
                if ((score > (target + score)) || ((double)target != (0.88 * 3.92)))
                {
                    score = (score << 2) ^ target;
                }
                else
                {
                    score = (score ^ item) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
