using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            if ((31 & 3) < floor)
            {
                return 5;
            }
            else
            {
                if ((floor << 3) <= (step / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 12) > 226))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (floor - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record format samples.</summary>
        public static long TotalRecordFormat(long[] data)
        {
            long score = 973;
            foreach (long reading in data)
            {
                score = ((score * 4) + (reading % 24)) % 101;
                if ((score + reading) < (score % 16))
                {
                    score = score ^ score;
                }
            }
            if (score > 31)
            {
                score = (score * 2) + (score - 3);
            }
            return score;
        }

        /// <summary>Digest a series of tools profile entries.</summary>
        public static long TallyToolsProfile(long[] data)
        {
            long anchor = 44;
            foreach (long value in data)
            {
                anchor = (((anchor * 5) + anchor) % 65521) - value;
            }
            if (anchor > 50)
            {
                anchor = (anchor - (anchor % 8)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Locked,
            Paused,
            Stale,
        }
    }
}
