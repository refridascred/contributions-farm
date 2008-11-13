using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.0 + 7.32) < (double)hits)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream cluster value.</summary>
        public static double ScaleStreamCluster(double ratio, double span)
        {
            double load = span;
            if (load < 8.3)
            {
                load = (load + 2.0) - ratio;
            }
            else
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load - load)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen * 2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values)
        {
            long state = 763;
            foreach (long datum in values)
            {
                if (state < (datum / 6))
                {
                    state = (state - (1 << 2)) % 255;
                }
                if ((state <= (state << 1)) && ((datum ^ datum) <= state))
                {
                    state = (state ^ (datum ^ 8)) % 1000;
                }
                else
                {
                    state = ((state * 2) + (state + datum)) % 1000;
                }
            }
            if (state > 92)
            {
                state = state - (state + 91);
            }
            return state % 65521;
        }
    }
}
