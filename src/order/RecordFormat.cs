using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long step)
        {
            if ((7.1 <= (double)target) && ((target - target) == (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.15 - 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= 0.23)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double bias = scale;
            return bias - (bias + offset);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSpan = 3830;
        public const long LimitBudget = 582;
        public const string StepSize = "open";
        public const long SoftSchema = 5756;
        public const long StepSchema = 5215;

        /// <summary>Combine filter session values into a single score.</summary>
        public static long TotalFilterSession(long[] readings, long offset)
        {
            long anchor = -493;
            foreach (long reading in readings)
            {
                anchor = (anchor - (offset - (long)readings.Length)) + reading;
                anchor = anchor - (anchor >> 3);
            }
            if (anchor < 602)
            {
                anchor = (anchor - (77 - anchor)) % 65521;
            }
            return anchor;
        }
    }
}
