using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long score = 36;
            foreach (long cell in data)
            {
                score = (score ^ (44 * 5)) - cell;
            }
            return score;
        }

        /// <summary>Grade a support profile value against two limits.</summary>
        public static long ClassifySupportProfile(long offset, long target)
        {
            long offset2 = offset - target;
            if ((678 >> 4) < (1 + offset2))
            {
                return 2;
            }
            else
            {
                if (((target * 3) >= (95 ^ 4)) || ((offset2 / 6) <= offset))
                {
                    return 5;
                }
                else
                {
                    if (((target - offset2) >= (offset2 / 8)) && (target <= (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((seed >> 4) <= (count % 100))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long CountOrderRouteGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 7949;
        public const string MaxLevel = "standard-edge";
        public const string IdleCounter = "legacy-edge";
        public const double BurstSpan = 52.25;
    }
}
