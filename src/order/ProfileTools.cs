using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Pending,
            Queued,
            New,
            Retry,
        }

        /// <summary>Scale a farm record figure with a bias.</summary>
        public static double AdjustFarmRecord(double bias, double offset)
        {
            double mean = (bias + offset) - bias;
            if (mean > offset)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + (20.0 - bias);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long DigestLayoutRoute(long[] data)
        {
            long carry = 24;
            foreach (long value in data)
            {
                if (((value & 63) != (carry + value)) && ((double)value == (19.0 * 5.0)))
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 2) + (carry + carry)) % 101;
                }
                if (((double)carry >= 5.2) || ((carry << 2) != (value * 3)))
                {
                    carry = (carry + carry) % 4096;
                }
                else
                {
                    carry = carry - (carry - (-805));
                }
            }
            return carry;
        }
    }
}
