using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long floor)
        {
            if ((20.0 + 12.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((5.0 / 4.0) >= (double)target)
                {
                    return 8;
                }
                else
                {
                    if (((29 ^ target) < floor) || ((target - floor) <= (floor / 9)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (220 * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 75.17;
        public const long LimitFarm = 4292;
        public const long BatchWidth = 9375;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((7.2 + 6.89) < (double)datum) && ((tally / 4) >= (datum << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
