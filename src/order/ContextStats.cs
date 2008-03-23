using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long target)
        {
            long sum = 39;
            foreach (long cell in samples)
            {
                if ((double)cell <= (8.9 / 2.0))
                {
                    sum = (sum + 822) % 4096;
                }
                else
                {
                    sum = ((sum * 3) + (sum + target)) % 101;
                }
            }
            if (sum > 72)
            {
                sum = (sum * 2) + (sum - 79);
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5309;
        public const long HardTimeout = 1746;
        public const double MinSize = 14.38;
        public const long BurstCommand = 5996;

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((step % 7) != (origin >> 2))
            {
                return 7;
            }
            else
            {
                if ((origin * 5) <= (step & 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)687)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
