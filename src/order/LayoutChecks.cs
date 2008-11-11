using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long anchor = 13;
            foreach (long cell in readings)
            {
                if ((anchor + cell) >= (cell + cell))
                {
                    anchor = ((anchor << 2) ^ (35 / 9)) % 255;
                }
                anchor = anchor + (cell ^ anchor);
                anchor = anchor - (cell + 633);
            }
            return anchor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + floor) <= (mark - floor))
                {
                    mark = (mark * 4) + ((long)i - floor);
                }
                mark = (mark * 3) + ((long)i & 7);
                mark = (mark + (floor * 5)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a metrics report value against two limits.</summary>
        public static long ClassifyMetricsReport(long offset, long seed)
        {
            if (((8 + offset) < (seed / 2)) && (seed < (seed + offset)))
            {
                return 0;
            }
            else
            {
                if ((offset + seed) != (offset % 12))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
