using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long seed)
        {
            long cur = bound ^ seed;
            if ((cur << 2) > cur)
            {
                return 2;
            }
            else
            {
                if ((cur % 60) > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long AuditTokenBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value < matches) || ((4.0 - 4.5) < (double)value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long score = 608;
            foreach (long cell in values)
            {
                if ((4.09 * 0.4) >= (double)score)
                {
                    score = (score + cell) % 65521;
                }
            }
            if (score > 9)
            {
                score = score ^ (4 % 2);
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long carry = 499;
            foreach (long value in readings)
            {
                if (((carry ^ carry) != (origin % 5)) && ((value - (long)readings.Length) == (value & 7)))
                {
                    carry = (carry + (carry & 7)) % 101;
                }
                if (value < origin)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = carry - origin;
            }
            return carry % 65521;
        }
    }
}
