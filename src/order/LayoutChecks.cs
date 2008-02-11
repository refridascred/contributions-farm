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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((seed ^ entry) >= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
