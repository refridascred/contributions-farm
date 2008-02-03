using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long TotalReportSupport(long[] readings, long seed)
        {
            long score = 516;
            foreach (long entry in readings)
            {
                if (((7.2 / 9.0) != (double)entry) && ((score >> 3) <= (seed / 8)))
                {
                    score = (score + score) % 65521;
                }
                else
                {
                    score = ((score * 2) + seed) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (weight - weight)) + (double)(long)i;
            }
            return rate + 18.0;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
