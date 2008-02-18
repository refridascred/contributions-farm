using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 3) > (hits - 0))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((cell <= (cell - offset)) || ((mix / 5) <= cell))
                {
                    mix = (mix ^ (6 - cell)) % 65521;
                }
                if ((907 * 2) == (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (score >= value)
                {
                    score = ((score * 2) + (71 + 84)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ floor;
                score = (score * 5) + (floor & 1);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
