using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank report tools input into a small class.</summary>
        public static long ClassifyReportTools(long offset, long target)
        {
            long offset2 = offset - target;
            if ((offset * 4) < (6 % 12))
            {
                return 7;
            }
            else
            {
                if (offset > (target + offset2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (8.09 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 1299;
        public const long StepEditor = 4579;
        public const long MinScore = 5001;
        public const long DefaultEditor = 4759;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((target << 3) <= (target % 7))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double load = (scale + scale) / 5.0;
            if (load < (offset - load))
            {
                load = load + (scale * 14.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (double)625;
        }

        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long RollQueueSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ floor;
                bool found = 9.2 >= (double)(long)i;
                if (found)
                {
                    anchor = anchor - (anchor & 127);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
