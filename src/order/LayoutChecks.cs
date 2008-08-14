using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (floor << 1)) - (long)i2;
                    result = (result ^ (result / 7)) % 65521;
                }
                result = (result ^ 97) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long AuditEntryNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item < (double)1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics layout counter forward.</summary>
        public static long RollMetricsLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((double)limit > (8.4 + 15.0))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor * 4)) % 101;
                    anchor = (anchor + ((-1) % 97)) % 1000;
                }
                anchor = ((anchor * 3) + (anchor + (long)i)) % 65521;
                if ((limit % 60) >= (limit ^ anchor))
                {
                    anchor = (anchor << 2) ^ 7;
                }
                else
                {
                    anchor = (anchor + (anchor + limit)) % 4096;
                    anchor = anchor ^ (649 / 2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record session readings against a rule.</summary>
        public static long AuditRecordSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) > tally) && ((datum + datum) != (tally ^ tally))) && (datum < (datum * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
