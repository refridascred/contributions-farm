using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry - 86) >= (4 / 9)) && ((entry << 3) <= (12 ^ entry)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long floor)
        {
            if (!(floor <= (4 - origin)))
            {
                return 8;
            }
            else
            {
                if (!(origin <= (floor - 9)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + 6) == (369 ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin % 100) >= (origin - floor)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a command account counter forward.</summary>
        public static long RollCommandAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (0.6 < (double)(long)i)
                {
                    sum = (sum + (-5)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long bound)
        {
            if ((double)floor <= 6.0)
            {
                return 8;
            }
            else
            {
                if (((-863) % 3) < (floor - 4))
                {
                    return 6;
                }
                else
                {
                    if (((bound + floor) < floor) && ((bound & 15) < (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor ^ floor) == (bound ^ (-78))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
