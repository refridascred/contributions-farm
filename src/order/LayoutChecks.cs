using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double load = 1.3;
            if (load >= load)
            {
                load = load + (bias / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)706) - (double)(long)i;
            }
            return load + (bias + scale);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long limit)
        {
            long bound = seed ^ limit;
            if ((limit + limit) <= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((limit + seed) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((seed > (seed + bound)) || ((bound & 3) != (limit - limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)698 > (double)seed) || (3.18 > (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((4.86 / 4.0) > (1.7 - 11.0))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
