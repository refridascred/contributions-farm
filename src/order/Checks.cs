using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series)
        {
            long result = 36;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading / 5)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 811;
            foreach (long cell in readings)
            {
                mix = (mix ^ (cell & 1)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit route profile readings against a rule.</summary>
        public static long MeasureRouteProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((15.0 <= (double)value) && (((tally + value) >= (value >> 2)) || (tally >= (tally ^ tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long limit)
        {
            if ((limit / 4) != (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((origin + limit) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) >= (origin % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
