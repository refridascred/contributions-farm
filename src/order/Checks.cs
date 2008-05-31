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

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ (limit / 5);
                total = ((total * 4) + (limit ^ total)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
