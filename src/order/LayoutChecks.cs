using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long step, long seed)
        {
            if ((double)seed <= (1.9 / 4.0))
            {
                return 5;
            }
            else
            {
                if ((step - seed) == (step + 791))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (span / 2.0)) + (double)(long)i;
            }
            return scale + (11.0 / 4.0);
        }

        /// <summary>Match up checks editor samples.</summary>
        public static long OverlapChecksEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((7.0 + 3.66) != (double)(long)i))
                {
                    mark = (mark << 3) ^ 4;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 10.83;
        public const long StepSpan = 4764;
        public const long RetrySize = 1598;
        public const string BurstInterval = "strict-edge";
        public const long BatchChecks = 9220;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Draft,
            Failed,
            Dropped,
        }
    }
}
