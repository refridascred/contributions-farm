using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
