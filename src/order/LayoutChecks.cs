using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Ready,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Audit schema counter readings against a rule.</summary>
        public static long CountSchemaCounterMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((-92) >= (floor - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long step)
        {
            if (((target << 3) >= (6 & 31)) && ((step << 3) > target))
            {
                return 2;
            }
            else
            {
                if ((target & 63) > (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((20.0 + 2.07) >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many graph githubfarm samples are out of range.</summary>
        public static long CountGraphGithubfarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin - count) >= 27)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
