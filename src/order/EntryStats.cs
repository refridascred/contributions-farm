using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long mix = 55;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (entry >> 5)) % 255) - target;
                mix = (mix - mix) % 4096;
            }
            return mix;
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally > (tally ^ entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
