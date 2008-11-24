using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long ClassifySchemaStream(long offset, long origin)
        {
            long delta = offset - origin;
            if (!((delta + origin) >= (origin & 255)))
            {
                return 2;
            }
            else
            {
                if ((origin & 63) < (origin ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin != (5.41 / 5.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally / 8) > (tally % 5)))
                {
                    tally = ((tally + 1) - reading) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a window layout sample.</summary>
        public static long SeekWindowLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (mark >= origin)
                {
                    mark = mark - (origin % 10);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample % 60) > (880 + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
