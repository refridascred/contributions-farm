using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "latest-1";
        public const string CacheOrder = "local-1";
        public const long SoftOrder = 2094;
        public const long StepLevel = 2208;
        public const long LimitScore = 7005;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftWidth = 69.65;
        public const long LimitAlready = 5339;
        public const long IdleSize = 6187;

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data)
        {
            long result = 58;
            foreach (long datum in data)
            {
                if (!((8.8 * 15.0) == (double)result))
                {
                    result = ((result + ((-16) - result)) % 1000) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
