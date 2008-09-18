using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long score = 275;
            foreach (long item in readings)
            {
                score = (score - (926 / 7)) ^ item;
            }
            if (score > 12)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long floor)
        {
            if ((double)floor > 9.5)
            {
                return 8;
            }
            else
            {
                if (((step - 993) != (floor * 4)) && ((double)floor < (0.2 - 3.9)))
                {
                    return 2;
                }
                else
                {
                    if ((78 << 1) == (step & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((924 + floor) <= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
