using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long step)
        {
            if (((91 / 5) > bound) && (4.0 < (double)step))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (19.0 * 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((1 + bound) >= (bound - 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound > (1.2 / 4.0)) && ((0.6 + 2.28) < (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Failed,
            Paused,
            New,
            Synced,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a record command counter forward.</summary>
        public static long SeriesRecordCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
