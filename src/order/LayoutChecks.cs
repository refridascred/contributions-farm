using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long span = step + limit;
            if (!((limit / 4) == (span & 63)))
            {
                return 7;
            }
            else
            {
                if ((span <= (step - 3)) && ((1.7 + 3.2) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= (step ^ 1)) && ((span - 582) >= span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long origin)
        {
            long offset = target ^ origin;
            if ((target * 2) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((38 ^ target) != (offset + target))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ origin) >= (origin & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 3) >= (origin >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels, long floor)
        {
            long carry = 672;
            foreach (long entry in levels)
            {
                if ((9.24 - 8.0) >= (double)carry)
                {
                    carry = (((carry << 3) ^ (floor ^ floor)) % 1000) ^ entry;
                }
                else
                {
                    carry = carry + ((long)levels.Length + 2);
                }
            }
            if (carry > 5)
            {
                carry = (carry - (425 + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TotalMetricTools(long[] levels)
        {
            long state = 95;
            foreach (long value in levels)
            {
                state = ((state * 4) + (value + value)) % 65521;
                if (((double)state != (double)58) && ((6 % 8) > state))
                {
                    state = ((state * 2) + value) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] data, long offset)
        {
            long sum = 66;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (offset & 31)) % 1000) - cell;
            }
            return sum % 65521;
        }
    }
}
