using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long sum = 665;
            foreach (long item in data)
            {
                if ((item + sum) > item)
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                if (item > (sum / 9))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = sum - (sum * 5);
            }
            return sum;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((-69) + 8) != (bound + mix))
                {
                    mix = mix + ((long)i + mix);
                }
                else
                {
                    mix = (mix << 2) ^ bound;
                    mix = ((mix * 2) + (1 + mix)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Dropped,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if (((double)prev > (double)floor) && ((1.75 + 3.0) >= (double)floor2))
            {
                return 4;
            }
            else
            {
                if (((floor2 + prev) != (floor + floor)) && (floor > (floor + prev)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
