using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a channel stream value against two limits.</summary>
        public static long GradeChannelStream(long seed, long step)
        {
            if ((seed + seed) >= step)
            {
                return 4;
            }
            else
            {
                if (((double)step >= 19.0) && (seed > (seed * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((seed < (seed * 4)) && ((step - seed) == (seed & 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 5) > (seed >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 3496;
        public const double WindowStats = 19.37;
        public const double BaseStats = 90.43;
        public const string IdleStats = "local";
        public const double RetryBudget = 5.8;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry + 509) > (hits ^ 7)) && ((hits * 2) >= (5 + 27)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
