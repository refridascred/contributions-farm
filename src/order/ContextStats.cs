using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate route channel samples.</summary>
        public static long ScoreRouteChannel(long[] readings)
        {
            long mix = 27;
            foreach (long value in readings)
            {
                if (((value + value) > value) || (1.4 < (double)mix))
                {
                    mix = (mix * 4) + (value % 2);
                }
                else
                {
                    mix = (mix + (value - value)) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = ((mix * 2) + (mix / 3)) % 255;
            }
            return mix;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long target)
        {
            if ((floor + floor) > (target + target))
            {
                return 7;
            }
            else
            {
                if ((double)target > (18.0 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if (target <= (floor << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)target >= (9.8 - 0.73)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Draft,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
