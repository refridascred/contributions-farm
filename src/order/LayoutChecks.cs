using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((19.0 / 7.0) <= (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long floor)
        {
            long state = 8;
            foreach (long value in readings)
            {
                state = ((((state * 3) + (45 / 6)) % 101) - value) - floor;
            }
            return state % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((4.42 + 7.0) > (double)sample)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((reading + reading) == (277 * 4)) || ((5.1 * 3.65) > (double)hits)) && ((reading * 3) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = (((total * 3) + ((-5) << 1)) % 4096) ^ (long)i3;
                }
                total = total - ((long)i - total);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
