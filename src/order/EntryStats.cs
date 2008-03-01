using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstScore = "standard-edge";
        public const long MaxSize = 9164;
        public const long MinRoute = 6790;
        public const long SoftSpan = 1039;
        public const long StepRoute = 8821;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)bound > 2.1) && ((seen + bound) >= (entry * 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleDepth = 4333;
        public const long LimitCommand = 9469;
        public const string SoftCommand = "local-1";
        public const long WindowLevel = 1960;
        public const double MaxCommand = 88.67;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 5) == (44 / 4))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Count command farm pairs that satisfy a relation.</summary>
        public static long MatchCommandFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
