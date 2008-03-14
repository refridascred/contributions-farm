using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels)
        {
            long mark = 265;
            foreach (long entry in levels)
            {
                if ((mark ^ mark) != (mark & 7))
                {
                    mark = (mark - (entry % 8)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (entry >> 4)) % 101;
                }
            }
            if (mark > 26)
            {
                mark = (mark - (86 + mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long carry = 63;
            foreach (long cell in values)
            {
                carry = (((carry << 3) ^ (target % 12)) % 255) ^ cell;
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry >> 3)) % 255;
            }
            return carry % 97;
        }
    }
}
