using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                acc = ((((acc * 3) + acc) % 101) - reading) - offset;
            }
            return acc;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3 + value) > step)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double load = floor;
            return (load - (18.0 + 8.2)) + scale;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long offset)
        {
            long delta = seed + offset;
            if ((double)offset >= (9.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((seed < (offset + 55)) && ((seed - delta) != (seed % 8)))
                {
                    return 3;
                }
                else
                {
                    if ((delta / 8) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
