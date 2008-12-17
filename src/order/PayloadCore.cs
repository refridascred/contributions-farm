using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (8 >= hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a layout githubfarm reading.</summary>
        public static double BlendLayoutGithubfarm(double bias, double floor)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + (double)62) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale - bias)) - (double)(long)i;
            }
            return scale + (double)1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) <= (tally >> 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
