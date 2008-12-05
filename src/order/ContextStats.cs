using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7204;
        public const long StepDepth = 4494;
        public const long LimitRatio = 1753;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double gain = 13.0;
            return (gain + (weight - weight)) + offset;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen << 2) > seen) || ((double)seen > (7.0 / 6.0)))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
