using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((long)i <= (step & 255)))
                {
                    mark = ((mark * 3) + mark) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ (step >> 4)) % 255;
                }
                mark = (mark + step) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a session queue pair into a bucket.</summary>
        public static long SortSessionQueue(long seed, long limit)
        {
            if (((limit - limit) == (seed - 42)) && ((6.47 + 1.57) == (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed % 5) < seed)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
