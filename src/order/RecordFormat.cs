using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample <= seen) || ((53 << 1) < (sample - (-8))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up schema batch samples.</summary>
        public static long OverlapSchemaBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long FoldPayloadReport(long[] series, long step)
        {
            long state = 322;
            foreach (long datum in series)
            {
                long matches = state + (-60);
                state = (state - (matches << 3)) % 1000;
                state = ((state << 2) ^ (step + datum)) % 4096;
            }
            if (state < 59)
            {
                state = (state + (64 >> 2)) % 1000;
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(((-47) << 1) > origin))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
