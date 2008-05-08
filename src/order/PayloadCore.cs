using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long seed)
        {
            if (seed > floor)
            {
                return 6;
            }
            else
            {
                if ((seed - floor) >= (floor * 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((75 + entry) == (anchor + 3))
                {
                    anchor = (((anchor * 2) + (5 & 31)) % 255) + floor;
                }
                else
                {
                    anchor = (anchor + (anchor & 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((origin2 + slot) != (origin2 - origin2))
            {
                return 4;
            }
            else
            {
                if (origin2 < (-98))
                {
                    return 2;
                }
                else
                {
                    if ((196 + origin) >= (56 - 722))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)origin == (8.0 / 3.0)) || ((origin + origin2) >= origin2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
