using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - (sum % 2);
                sum = (sum + (sum - bound)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)seed >= (16.0 * 8.7))
            {
                return 8;
            }
            else
            {
                if (4 < (edge - origin))
                {
                    return 0;
                }
                else
                {
                    if (edge < (edge % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed > 1.3) && ((edge / 9) <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (0.37 * 5.7))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long TallySessionEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 4) < (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
