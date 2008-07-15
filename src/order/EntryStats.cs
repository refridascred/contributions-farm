using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 4) >= (entry ^ entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen != (8.0 * 9.13)) || ((80 * 3) >= target))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long GradeBatchesSupport(long bound, long target)
        {
            if ((52 / 5) < target)
            {
                return 8;
            }
            else
            {
                if (((target << 3) > bound) && ((double)bound > 2.4))
                {
                    return 6;
                }
                else
                {
                    if ((target / 2) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
