using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((bound + hits) < (hits + bound))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 3449;
        public const long LimitAccount = 9322;
        public const long BurstCount = 2016;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < 291)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - 56) > (count >> 4))
                {
                    count = ((count + 3) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = 1.0;
            if (rate >= bias)
            {
                rate = (rate + (double)591) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
