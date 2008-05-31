using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long step)
        {
            long cur = floor - step;
            if ((3.5 + 13.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((step + cur) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((78 ^ floor) == (floor / 8))
                {
                    total = (total - (floor + floor)) % 255;
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -2;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry << 3) ^ 0) % 255) ^ (long)i;
                }
                carry = (carry << 3) ^ carry;
                carry = (carry << 2) ^ (6 - entry);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many tools cache samples are out of range.</summary>
        public static long TallyToolsCacheOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((step / 8) < (step + step))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (acc ^ (long)i)) % 97;
                acc = acc + (long)i;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
