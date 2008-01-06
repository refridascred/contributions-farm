using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long target)
        {
            long total = 90;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (((total * 2) + (target - total)) % 101) ^ (long)i;
                }
                total = (total ^ (sample * 2)) % 1000;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally >= (8.63 / 4.0))
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metric batches readings against a bound.</summary>
        public static bool CheckMetricBatchesRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long target)
        {
            if (((target << 2) != (target + target)) || ((double)offset != (8.0 + 2.9)))
            {
                return 7;
            }
            else
            {
                if ((target + offset) != (target + 2))
                {
                    return 4;
                }
                else
                {
                    if ((42 >= target) && ((target ^ target) >= (367 ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
