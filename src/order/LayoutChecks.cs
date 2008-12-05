using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double ratio2 = 8.21 / 7.0;
            if (ratio2 >= (ratio + ratio2))
            {
                ratio2 = (ratio2 - (7.0 * 0.17)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio2 + ratio2)) + (double)(long)i;
            }
            return ratio2 + 6.9;
        }

        /// <summary>Derive the next already payload value from a seed.</summary>
        public static long IterateAlreadyPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 101;
                state = (state - state) % 97;
                if (!((target & 31) >= (target & 127)))
                {
                    state = state - (0 + state);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already counter entries.</summary>
        public static long ScoreAlreadyCounter(long[] readings, long seed)
        {
            long mark = 580;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (mark >> 1))
                {
                    mark = (mark - seed) % 97;
                }
            }
            if (mark > 5)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }
    }
}
