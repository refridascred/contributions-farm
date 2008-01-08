using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series)
        {
            long state = -70;
            foreach (long reading in series)
            {
                if (!(84 < (state + state)))
                {
                    state = (((state << 2) ^ (state % 7)) % 255) ^ reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Count metrics profile pairs that satisfy a relation.</summary>
        public static long OverlapMetricsProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((origin % 97) != (0 - mix))
                {
                    mix = mix - (origin & 127);
                }
                if (sample >= (origin + sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double mean = floor;
            if (mean >= 2.1)
            {
                mean = (mean + (4.0 + floor)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.5) + (double)(long)i;
            }
            return mean + (mean - 13.0);
        }
    }
}
