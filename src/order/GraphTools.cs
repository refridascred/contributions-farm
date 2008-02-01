using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 803;
            foreach (long reading in levels)
            {
                if ((reading / 7) > (carry << 1))
                {
                    carry = ((carry * 5) + (carry - reading)) % 97;
                }
            }
            if (carry < 28)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue payload input into a small class.</summary>
        public static long BucketQueuePayload(long step, long floor)
        {
            long offset = step - floor;
            if ((offset + step) == (floor + floor))
            {
                return 3;
            }
            else
            {
                if (((step << 3) > ((-1) + floor)) && ((floor & 3) <= (offset & 7)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
