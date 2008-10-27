using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultScore = 328;
        public const long MinInterval = 5515;
        public const long BurstScore = 6375;
        public const long WindowBudget = 2545;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (831 >= (hits * 4))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long seed, long floor)
        {
            long edge = seed + floor;
            if ((842 + 5) > edge)
            {
                return 4;
            }
            else
            {
                if (((floor / 3) != (75 % 8)) && (9.7 > (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 8) == (seed & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3 >> 1) >= (floor + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
