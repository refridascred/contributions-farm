using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ ((long)i * 5)) % 4096;
                score = ((score * 5) + (offset - (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the report buffer series from a seed.</summary>
        public static long RollReportBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 2) ^ (limit * 5)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
