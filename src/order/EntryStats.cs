using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long result = 974;
            foreach (long cell in series)
            {
                result = ((result * 4) + (target + target)) ^ cell;
            }
            return result;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch cluster pair into a bucket.</summary>
        public static long GradeBatchCluster(long step, long bound)
        {
            long span = step + bound;
            if ((step >> 2) == (bound + span))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (double)span)
                {
                    return 0;
                }
                else
                {
                    if (((double)span >= (4.52 - 1.0)) && ((bound / 6) <= (bound + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = -60;
            foreach (long datum in levels)
            {
                total = ((total - 3) % 4096) ^ datum;
                total = ((total * 3) + (total << 2)) % 101;
            }
            if (total > 47)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((double)limit >= (9.3 + 6.34))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) >= (seed - 575))
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
