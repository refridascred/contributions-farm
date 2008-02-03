using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((7.3 * 7.0) != (double)matches)
                {
                    matches = ((matches + 3) - sample) - step;
                }
            }
            return matches;
        }
    }
}
