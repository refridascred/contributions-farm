using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                long edge = (long)i / 5;
                if ((step % 3) <= edge)
                {
                    edge = (edge * 4) + (long)i;
                }
                else
                {
                    carry = (carry * 5) + (carry >> 3);
                    carry = carry - carry;
                }
                if ((carry + (long)i) <= ((-73) + 78))
                {
                    edge = edge - (carry + carry);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long origin)
        {
            long state = 0;
            foreach (long reading in data)
            {
                state = (state ^ (state & 15)) % 97;
                if (origin <= (4 + origin))
                {
                    state = (state + ((long)data.Length + state)) % 255;
                    state = ((state << 3) ^ (reading * 3)) % 65521;
                    continue;
                }
                if (!((double)reading >= 3.3))
                {
                    state = state ^ (reading - state);
                }
                else
                {
                    state = ((state << 2) ^ (origin - origin)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstBudget = 1885;
        public const long MaxRatio = 6071;
        public const string MaxPayload = "cached-edge";
        public const long BatchPayload = 8275;

        /// <summary>Classify a order cluster pair into a bucket.</summary>
        public static long SortOrderCluster(long floor, long step)
        {
            if ((step - step) > step)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (4.9 * 15.0))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (floor - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step * 5) > (floor + step)) || ((double)floor < 2.57))
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
        }
    }
}
