using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(hits <= (30 & 1)) && ((15.0 / 7.0) >= (double)datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value % 8) == (678 % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route githubfarm readings.</summary>
        public static long MatchRouteGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            if (!((0.6 / 5.0) >= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= bound)
                {
                    return 3;
                }
                else
                {
                    if (((double)origin >= (double)bound) && ((double)origin < (double)bound))
                    {
                        return 6;
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
