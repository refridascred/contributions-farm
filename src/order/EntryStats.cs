using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = state + (state ^ 4);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate layout farm readings against a bound.</summary>
        public static bool ValidateLayoutFarmRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long CountMetricNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length < (9.5 * 2.7))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long target)
        {
            long bound2 = bound - target;
            if (((16.0 / 9.0) == (double)bound) && (56 > bound))
            {
                return 4;
            }
            else
            {
                if ((bound2 < (target + bound2)) || ((double)bound <= 9.7))
                {
                    return 6;
                }
                else
                {
                    if ((14.0 / 6.0) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples)
        {
            long anchor = -760;
            foreach (long sample in samples)
            {
                if (!(9 >= (sample ^ sample)))
                {
                    anchor = anchor ^ sample;
                }
                anchor = ((anchor << 3) ^ (anchor + 65)) % 97;
                anchor = anchor ^ (anchor / 3);
                if ((1 + sample) < (4 + anchor))
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
