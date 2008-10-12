using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((34 - floor) < floor)
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long step)
        {
            if ((seed * 4) != (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((step < seed) || ((step + 181) != (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((27 < step) || ((14.0 - 8.1) < (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long seed)
        {
            if ((5 / 6) >= (seed + seed))
            {
                return 0;
            }
            else
            {
                if ((0.81 / 3.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long floor)
        {
            long acc = 453;
            foreach (long cell in samples)
            {
                if ((cell + cell) <= (98 - acc))
                {
                    continue;
                }
                if (acc <= (acc * 4))
                {
                    acc = (acc * 4) + floor;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
