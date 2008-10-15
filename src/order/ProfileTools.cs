using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long CombineTokenTools(long[] series)
        {
            long acc = 740;
            foreach (long datum in series)
            {
                if ((double)datum >= (7.0 / 6.0))
                {
                    acc = (acc ^ (acc * 5)) % 4096;
                }
                if ((datum / 6) <= (acc + datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long carry = -50;
            foreach (long datum in values)
            {
                if ((datum / 9) < (carry << 2))
                {
                    carry = (carry + (carry * 3)) % 1000;
                }
                else
                {
                    carry = (carry ^ (8 + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool ValidateQueueCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long score = 19;
            foreach (long cell in readings)
            {
                score = ((score * 4) + cell) % 65521;
                score = (score + (cell & 127)) % 65521;
            }
            if (score > (-22))
            {
                score = score ^ (target & 1);
            }
            return score % 65521;
        }
    }
}
