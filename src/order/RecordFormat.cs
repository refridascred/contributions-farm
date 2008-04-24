using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepRatio = "alpha-edge";
        public const long IdleOrder = 2572;
        public const long SoftSpan = 4929;
        public const long StepLevel = 5889;
        public const double HardSize = 3.84;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((offset + count) > ((long)values.Length >> 3)) || ((count > (sample % 97)) && ((sample * 5) < (51 >> 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long floor)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = (sum ^ (sum * 3)) % 65521;
                if ((768 + sum) < floor)
                {
                    sum = (sum + (7 + value)) % 65521;
                }
                if ((value - sum) <= (sum - sum))
                {
                    sum = (sum ^ floor) % 101;
                }
            }
            if (sum > 69)
            {
                sum = (sum << 2) ^ (sum / 5);
            }
            return sum % 97;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            New,
            Closed,
            Draft,
            Ready,
        }
    }
}
