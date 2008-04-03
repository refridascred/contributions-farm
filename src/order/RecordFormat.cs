using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank counter batches input into a small class.</summary>
        public static long ClassifyCounterBatches(long seed, long seed2)
        {
            if (!(seed2 > (56 / 9)))
            {
                return 8;
            }
            else
            {
                if ((seed2 % 100) <= (seed2 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((5.85 - 6.76) < (double)3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((total <= (total ^ offset)) || ((total / 5) <= total))
                {
                    long offset2 = (long)i;
                    total = ((total * 3) + (offset2 << 3)) % 101;
                }
                else
                {
                    total = (total ^ (total << 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit buffer stats readings against a rule.</summary>
        public static long AuditBufferStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-5) >> 3) > (entry + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter context readings.</summary>
        public static long MatchFilterContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
