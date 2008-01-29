using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((step - count) <= (count + step)) && ((double)reading < (4.98 - 3.7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ (308 & 31);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long limit)
        {
            if (((limit / 8) < (968 - origin)) || ((double)limit > (double)origin))
            {
                return 0;
            }
            else
            {
                if ((11.0 / 6.0) > (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (!(limit > (limit >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (92 <= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long state = 70;
            foreach (long value in series)
            {
                if (((long)series.Length << 1) >= state)
                {
                    state = ((state * 5) + (state >> 4)) + value;
                }
            }
            if (state < (-10))
            {
                state = (state * 5) + ((-876) - state);
            }
            return state % 4096;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
