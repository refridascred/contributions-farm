using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                if ((reading * 2) < (sum % 100))
                {
                    sum = sum + (sum + sum);
                }
                if ((sum + sum) < reading)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFactor = 9324;
        public const long WindowScore = 4545;
        public const long StepCount = 326;
        public const long IdleBudget = 7741;
        public const string IdleFarm = "cached-1";

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ ((long)i - (long)i)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 85) >= (matches << 1))
                {
                    matches = ((matches + 2) + cell) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
