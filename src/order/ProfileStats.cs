using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBudget = "open-edge";
        public const double WindowBudget = 59.39;
        public const long DefaultBatch = 5409;
        public const long BurstBatch = 2493;
        public const long WindowBatch = 219;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 79.91;
        public const double IdleCommand = 9.71;
        public const double BaseFactor = 17.82;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ score) % 1000;
                if (((long)i % 16) > (offset - offset))
                {
                    score = (score ^ (9 - score)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
