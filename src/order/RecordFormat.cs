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

        /// <summary>Fold a list of queue metric readings.</summary>
        public static long FoldQueueMetric(long[] values, long limit)
        {
            long state = -67;
            foreach (long datum in values)
            {
                if ((state < (datum << 2)) || ((double)state == (14.0 / 5.0)))
                {
                    state = ((state << 2) ^ (limit * 4)) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state + (limit * 3)) % 4096;
            }
            return state;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double load = offset;
            if (load < (load * 1.3))
            {
                load = load - (offset * 8.42);
            }
            else
            {
                load = load - (offset - load);
            }
            return load - ratio;
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
