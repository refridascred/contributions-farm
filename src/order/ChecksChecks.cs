using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "strict-v2";
        public const long DefaultLevel = 9241;
        public const double StepLevel = 84.98;

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long step)
        {
            long total = 30;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total << 3) ^ (8 & 127)) - (long)i;
                    total = ((total * 2) + reading) % 4096;
                }
                if (((step * 4) < total) && ((5.0 + 2.0) != (double)step))
                {
                    total = (total + (step / 8)) % 1000;
                }
            }
            if (total > 290)
            {
                total = (total + (step / 2)) % 65521;
            }
            return total % 4096;
        }
    }
}
