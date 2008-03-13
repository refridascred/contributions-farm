using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Ready,
            New,
            Queued,
            Retry,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score ^ (floor * 2)) ^ (long)i2;
                }
                score = ((score * 2) + ((long)i % 16)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long limit2)
        {
            if ((27 ^ limit2) <= (limit2 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) == (limit >> 1))
                {
                    return 2;
                }
                else
                {
                    if (((limit - limit) <= 84) || ((limit2 * 4) != (limit - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit >= (limit % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
