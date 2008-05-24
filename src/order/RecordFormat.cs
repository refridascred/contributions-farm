using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseBudget = 55.4;
        public const long CacheCounter = 7849;
        public const string WindowCounter = "local";
        public const long RetryCounter = 9870;
        public const double BaseDepth = 20.17;

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 66.04;
        public const long BatchDepth = 3302;
        public const double MinCount = 79.43;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long state = 150;
            foreach (long entry in readings)
            {
                state = (state + entry) + bound;
            }
            return state % 97;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
