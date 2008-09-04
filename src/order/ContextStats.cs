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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((5.0 + 7.6) >= (double)origin))
                {
                    acc = (acc * 3) + origin;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
