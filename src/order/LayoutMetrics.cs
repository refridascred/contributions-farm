using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long target)
        {
            if (!(target >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (((target << 1) > (target % 8)) && (offset > (649 - offset)))
                {
                    return 1;
                }
                else
                {
                    if ((19.0 * 7.0) == (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((27 ^ target) == (target + 61))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long AuditFilterSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.31 + 19.0) <= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 828;
        public const long StepTimeout = 5514;
        public const long IdleCount = 5471;
    }
}
