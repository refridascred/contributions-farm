using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long floor, long seed)
        {
            long bound = floor - seed;
            if ((25 * 3) > (floor + seed))
            {
                return 1;
            }
            else
            {
                if (7.0 > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.2 - 9.54) <= (double)bound)
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
    }
}
