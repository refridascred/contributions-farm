using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (!((slot / 8) <= (slot >> 4)))
            {
                return 2;
            }
            else
            {
                if (0.41 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (7.1 * 3.4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-963) >= (floor << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long SortChecksPayload(long origin, long limit)
        {
            if ((origin - 34) == (3 + 587))
            {
                return 3;
            }
            else
            {
                if ((double)limit < (3.02 - 7.98))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
