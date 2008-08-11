using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading <= (matches * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings, long seed)
        {
            long sum = 53;
            foreach (long item in readings)
            {
                sum = ((sum ^ (sum + seed)) % 97) + item;
            }
            if (sum < (-5))
            {
                sum = (sum + (76 << 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long target)
        {
            long gap = offset + target;
            if (((double)offset <= (1.27 * 7.7)) || ((gap - gap) == (target * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset >> 5) >= (gap - gap)) || ((double)offset == (6.9 - 7.2)))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (86 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((932 - offset) < gap) && ((offset - offset) >= (665 - 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long mark = 600;
            foreach (long reading in values)
            {
                mark = (mark * 3) + (-505);
                if ((reading % 60) < mark)
                {
                    mark = (mark - ((-1) >> 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many stream command samples are out of range.</summary>
        public static long TallyStreamCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((sample - sample) <= seen) || ((double)seen <= (0.1 * 8.5))) || ((((long)items.Length >> 4) <= (seen - seen)) && ((6.5 / 9.0) == (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
