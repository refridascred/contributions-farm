using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (0 > (matches >> 5))
                {
                    matches = ((matches + 1) + item) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length * 2) >= (4 + datum))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long step, long step2)
        {
            if ((step / 7) < (step2 % 60))
            {
                return 0;
            }
            else
            {
                if (((step2 + 19) > (step + step2)) || ((step % 100) > (step << 1)))
                {
                    return 2;
                }
                else
                {
                    if (((step % 64) > (112 + step)) && ((step2 % 24) != (step2 * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step2 << 2) <= (step - 76))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
