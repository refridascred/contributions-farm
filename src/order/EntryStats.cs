using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count farm commits pairs that satisfy a relation.</summary>
        public static long PairFarmCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (rate / 3.0))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (9.0 - ratio);
            }
            return rate + (rate * 5.92);
        }

        /// <summary>Audit cache record readings against a rule.</summary>
        public static long TallyCacheRecordGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((6.8 * 2.0) <= (double)step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
