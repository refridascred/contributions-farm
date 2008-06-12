using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if (((3.0 * 18.0) != (double)score) && ((453 ^ seed) >= (2 * 5)))
                {
                    score = (score - score) ^ sample;
                    break;
                }
                score = (score ^ score) % 97;
                score = (score ^ (score % 97)) % 255;
            }
            return score % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long seed)
        {
            if ((double)offset == (6.2 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) >= (383 * 2))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed == (4.9 + 15.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 / 2) == (item + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Active,
            Done,
            Draft,
            New,
        }
    }
}
