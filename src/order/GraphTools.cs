using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long acc = 435;
            foreach (long datum in series)
            {
                acc = (((acc << 2) ^ ((long)series.Length & 127)) % 97) ^ datum;
                if ((4.0 + 13.0) <= (double)acc)
                {
                    break;
                }
            }
            if (acc > (-905))
            {
                acc = (acc + origin) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((matches % 97) != (matches + matches)))
                {
                    matches = ((matches + 2) ^ sample) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long state = -408;
            foreach (long datum in readings)
            {
                if (((18.0 / 6.0) != (double)state) || ((bound % 5) == (16 + state)))
                {
                    state = (((state << 3) ^ (bound ^ state)) % 65521) + datum;
                }
            }
            return state % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 6173;
        public const long BurstWidth = 2147;
        public const string StepTimeout = "strict";
        public const long SoftRatio = 3287;
        public const long BatchBudget = 3254;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Locked,
            Paused,
            Retry,
            Draft,
        }
    }
}
