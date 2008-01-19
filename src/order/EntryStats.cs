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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading * 4) == (9 - 13)) && (reading > (count + 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
