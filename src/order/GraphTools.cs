using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a entry already sample.</summary>
        public static long LookupEntryAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] readings, long step)
        {
            long total = 1;
            foreach (long cell in readings)
            {
                if ((cell / 7) < (total + cell))
                {
                    total = ((total << 2) ^ (long)readings.Length) + step;
                }
            }
            if (total > 20)
            {
                total = (total - total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool ValidateBatchSchemaBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
