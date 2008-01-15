using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 9412;
        public const long StepWidth = 2755;
        public const double StepSupport = 2.53;
        public const double RetryRatio = 0.71;
        public const long LimitSupport = 4741;

        /// <summary>Combine record layout values into a single score.</summary>
        public static long TotalRecordLayout(long[] items, long limit)
        {
            long total = 866;
            foreach (long reading in items)
            {
                if (((reading - limit) > (limit + (-574))) && ((limit & 3) >= total))
                {
                    total = ((total << 3) ^ (reading + limit)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long target)
        {
            long result = 15;
            foreach (long reading in data)
            {
                result = result + (reading + target);
            }
            return result % 65521;
        }
    }
}
