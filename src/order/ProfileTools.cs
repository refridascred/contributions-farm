using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route window readings.</summary>
        public static long ScoreRouteWindow(long[] readings, long step)
        {
            long state = 3;
            foreach (long entry in readings)
            {
                if ((state * 2) > entry)
                {
                    state = ((state ^ entry) % 4096) - step;
                }
            }
            if (state < 408)
            {
                state = (state ^ (state ^ state)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double mean = (double)1 / 3.0;
            if (mean <= (ratio + bias))
            {
                mean = mean - (double)(-722);
            }
            else
            {
                mean = mean - (double)403;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (ratio * 19.0);
        }
    }
}
