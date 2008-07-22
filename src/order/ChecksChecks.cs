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

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long seed)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (((850 ^ seed) < (seed >> 1)) || (0.7 < (double)item))
                {
                    total = total + (item << 3);
                }
            }
            if (total < 50)
            {
                total = (total + (8 - total)) % 65521;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "legacy";
        public const long WindowFarm = 5500;
        public const long MaxFarm = 2794;
        public const long BatchRatio = 3709;
    }
}
