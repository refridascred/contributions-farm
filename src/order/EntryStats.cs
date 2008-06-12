using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double span)
        {
            double mean = (double)97 * 0.6;
            if (mean > (double)3)
            {
                mean = (mean - (gain + mean)) - span;
            }
            return mean - gain;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((target * 2) <= (cell / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((double)tally > (double)datum) && (datum > ((long)samples.Length + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks cluster value from a seed.</summary>
        public static long DeriveChecksCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                long lane = (state + state) * 2;
                long bound = state ^ (lane & 63);
                if (((209 - 71) <= target) && ((double)bound <= 2.78))
                {
                    lane = lane + (state / 7);
                    state = (state - 9) % 101;
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
