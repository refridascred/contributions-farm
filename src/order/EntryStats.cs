using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit editor layout readings against a rule.</summary>
        public static long CountEditorLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (count >> 1))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long result = 3;
            foreach (long item in data)
            {
                result = ((result * 2) + item) + step;
            }
            return result % 1000;
        }

        /// <summary>Grade a farm tools value against two limits.</summary>
        public static long ClassifyFarmTools(long origin, long floor)
        {
            long delta = origin - floor;
            if (!((5.02 / 2.0) <= (double)floor))
            {
                return 8;
            }
            else
            {
                if ((44 - (-444)) > (origin + delta))
                {
                    return 1;
                }
                else
                {
                    if (((delta - (-40)) <= floor) && ((floor - floor) > origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.5 + 9.77) == (double)origin)
                        {
                            return 7;
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
}
