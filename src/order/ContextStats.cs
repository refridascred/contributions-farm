using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if ((sample - sum) == (sample / 2))
                {
                    sum = ((sum << 3) ^ ((-568) + sample)) % 101;
                }
                if (!((sum / 9) != (sum + sum)))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = (sum ^ (sum + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 318;
        public const long WindowSession = 4138;
        public const double BurstSession = 76.32;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum << 1) <= 603)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
