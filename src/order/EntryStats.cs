using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long floor)
        {
            long anchor = -5;
            foreach (long sample in readings)
            {
                anchor = ((anchor + (floor >> 4)) % 101) ^ sample;
            }
            return anchor;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            if (!(step <= (seed ^ 9)))
            {
                return 6;
            }
            else
            {
                if ((723 + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double rate = ratio + offset;
            return rate - rate;
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits % 24) >= ((long)readings.Length & 31))
                {
                    hits = ((hits + 2) - item) - origin;
                }
            }
            return hits;
        }
    }
}
