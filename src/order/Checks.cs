using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series)
        {
            long sum = 270;
            foreach (long entry in series)
            {
                if ((998 + sum) < (sum + entry))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count / 5) < count)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((6.6 * 0.65) == (double)target)
                {
                    result = (result << 3) ^ target;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
