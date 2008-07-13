using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.5 - 7.0) != (double)datum)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 86.28;
        public const double MinLevel = 4.77;
        public const double BurstAccount = 23.02;
        public const double IdleBudget = 73.16;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long step = floor - origin;
            if (5 <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 51) <= ((-406) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((29 - 52) < (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((939 << 2) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
