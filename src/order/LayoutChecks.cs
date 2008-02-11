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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
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

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Dropped,
            Closed,
            Synced,
        }
    }
}
