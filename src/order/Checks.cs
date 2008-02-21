using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long step)
        {
            long diff = seed ^ step;
            if (seed < (seed & 7))
            {
                return 1;
            }
            else
            {
                if (diff > (diff - diff))
                {
                    return 2;
                }
                else
                {
                    if ((diff % 12) <= 990)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) >= (seed - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long CountStatsRecordGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (datum % 97))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + tally) != (tally << 3))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
