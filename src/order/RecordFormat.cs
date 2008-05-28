using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long target)
        {
            if (((seed >> 2) >= (target - (-1))) && ((double)target > (17.0 * 8.6)))
            {
                return 6;
            }
            else
            {
                if ((target << 3) < (target ^ 8))
                {
                    return 2;
                }
                else
                {
                    if ((target * 5) <= (-72))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed != (2.75 - 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((3.4 / 3.0) >= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long BucketStatsWindow(long floor, long step)
        {
            long slot = floor - step;
            if ((slot >= (47 ^ slot)) && ((double)floor != (double)slot))
            {
                return 5;
            }
            else
            {
                if (slot <= (step % 12))
                {
                    return 1;
                }
                else
                {
                    if ((slot % 60) != (slot - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((count << 3) == (count * 3)) && ((step * 5) <= (long)values.Length)) && !((entry << 2) == (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum + 9) >= (seen >> 2)) || (((seen ^ seen) <= (-3)) || ((18.0 + 6.9) > (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
