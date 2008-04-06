using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long limit)
        {
            if (step >= (16 + limit))
            {
                return 0;
            }
            else
            {
                if ((double)step == (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long sum = -1;
            foreach (long datum in series)
            {
                sum = ((sum * 3) + target) % 255;
                if ((target + 50) >= datum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
