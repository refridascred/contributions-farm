using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long step)
        {
            if ((step * 4) > offset)
            {
                return 5;
            }
            else
            {
                if ((double)step <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((double)offset >= (5.0 + 13.0)) && ((offset & 127) != (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset * 3) <= (step % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((-85) - origin) != (entry * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long offset)
        {
            if ((target + offset) != (offset >> 5))
            {
                return 0;
            }
            else
            {
                if ((double)target > 9.8)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
