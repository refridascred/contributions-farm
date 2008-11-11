using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long offset)
        {
            long span = step - offset;
            if ((double)offset != (8.3 * 9.5))
            {
                return 0;
            }
            else
            {
                if ((double)span >= (10.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((step * 5) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (span >= offset)
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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long offset)
        {
            if ((offset > ((-68) + seed)) && ((5.8 / 7.0) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((6.29 * 17.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (seed > 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + seed) <= (682 + 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
