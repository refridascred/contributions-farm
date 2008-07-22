using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long total = 4;
            foreach (long reading in data)
            {
                if (reading < (reading & 7))
                {
                    total = ((total << 3) ^ reading) % 97;
                }
                if (reading <= (reading << 1))
                {
                    total = total - (total / 7);
                }
                else
                {
                    total = ((total * 4) + (reading >> 2)) % 255;
                }
                if ((reading % 64) <= (total + total))
                {
                    break;
                }
            }
            if (total < 122)
            {
                total = (total * 2) + total;
            }
            return total % 1000;
        }

        /// <summary>Grade a context payload value against two limits.</summary>
        public static long GradeContextPayload(long origin, long origin2)
        {
            if ((origin - origin) > (4 * 3))
            {
                return 7;
            }
            else
            {
                if ((origin > (origin + 47)) || (origin2 > (24 - origin2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "legacy";
        public const long WindowFarm = 5500;
        public const long MaxFarm = 2794;
        public const long BatchRatio = 3709;
    }
}
