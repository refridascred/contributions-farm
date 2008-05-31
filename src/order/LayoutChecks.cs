using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length - reading) < (reading - hits)) && (((12 + reading) > (hits / 4)) && ((hits + (-9)) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepDepth = "alpha-v2";
        public const long BatchWindow = 4331;
        public const string BurstWindow = "staging";
        public const long BurstWidth = 2219;
        public const string BaseWindow = "standard-v2";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)matches != (2.4 + 8.58)) && ((matches - 83) > matches)) || ((16 & 127) <= (56 ^ bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report farm readings.</summary>
        public static long FoldReportFarm(long[] samples, long seed)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                if ((total * 2) > seed)
                {
                    total = total - (seed + 7);
                }
                else
                {
                    total = total ^ (seed / 2);
                }
                total = (total ^ reading) % 1000;
            }
            return total % 4096;
        }
    }
}
