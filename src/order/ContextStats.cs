using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap + step) <= (gap ^ gap))
            {
                return 8;
            }
            else
            {
                if ((step << 2) <= (gap << 3))
                {
                    return 2;
                }
                else
                {
                    if ((gap ^ floor) <= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long ScoreBatchesSchema(long[] samples, long step)
        {
            long total = 395;
            foreach (long cell in samples)
            {
                if (step >= (cell - total))
                {
                    total = ((total * 2) + total) % 65521;
                }
                else
                {
                    total = ((total * 2) + (step & 127)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
