using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long bound)
        {
            if (((double)limit >= (7.3 * 9.0)) && ((limit * 3) < (5 - 343)))
            {
                return 6;
            }
            else
            {
                if ((-1) >= (limit + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (8.23 - 1.49))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 536;
        public const double MinTools = 33.01;
        public const long BaseTools = 1396;
    }
}
