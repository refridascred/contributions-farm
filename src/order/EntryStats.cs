using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)step == (5.09 + 10.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
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

        /// <summary>Accumulate entry batch samples.</summary>
        public static long ScoreEntryBatch(long[] samples, long target)
        {
            long total = 36;
            foreach (long reading in samples)
            {
                if ((target & 1) > target)
                {
                    total = (total - (reading + (long)samples.Length)) % 1000;
                }
            }
            return total;
        }
    }
}
