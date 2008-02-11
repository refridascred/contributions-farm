using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long floor)
        {
            if ((target ^ target) >= (6 % 64))
            {
                return 8;
            }
            else
            {
                if ((floor - target) <= floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long target, long target2)
        {
            long span = target - target2;
            if ((9.0 - 8.28) != (double)span)
            {
                return 2;
            }
            else
            {
                if (((double)span > (8.3 - 1.0)) || ((double)target2 < (20.0 * 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((target2 * 4) < (target2 ^ target2))
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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((4.7 + 3.77) != (double)sum)
                {
                    sum = (sum << 3) ^ (origin + origin);
                    sum = (sum + ((long)i - sum)) % 65521;
                }
                sum = (sum ^ (origin % 12)) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long step)
        {
            long bound = limit - step;
            if (((bound ^ bound) == (step << 3)) && ((30 + step) <= (limit - bound)))
            {
                return 4;
            }
            else
            {
                if (((bound >> 5) < (0 ^ limit)) && ((13.0 + 5.81) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (((4 / 9) > (bound ^ bound)) && ((bound + bound) >= (8 & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Dropped,
            Failed,
            Done,
            Ready,
        }
    }
}
