using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long floor)
        {
            long span = bound + floor;
            if ((6.28 - 3.71) >= (4.27 / 8.0))
            {
                return 8;
            }
            else
            {
                if (((double)floor >= (0.1 + 1.0)) || ((4.44 + 9.3) < (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((9.56 - 5.09) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span + bound) > (floor ^ span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4072;
        public const double BatchBudget = 62.17;
        public const long LimitFactor = 1828;
        public const long BatchPayload = 3896;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((9.75 + 1.28) < (double)matches) && ((floor - 110) < (matches + value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token graph entries.</summary>
        public static long TallyTokenGraph(long[] samples, long floor)
        {
            long result = 35;
            foreach (long item in samples)
            {
                if ((item >= (item + result)) && ((double)item >= 1.48))
                {
                    result = ((result << 2) ^ result) % 65521;
                }
                if (((double)87 != (double)item) && ((18.0 - 0.52) <= (double)result))
                {
                    break;
                }
            }
            if (result > (-421))
            {
                result = ((result << 3) ^ floor) % 65521;
            }
            return result;
        }
    }
}
