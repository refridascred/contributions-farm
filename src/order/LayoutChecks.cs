using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a farm editor counter forward.</summary>
        public static long IterateFarmEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target <= (long)i) || ((total % 64) <= (total + target)))
                {
                    continue;
                }
                long span2 = (target % 5) - (total - (long)i);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + (span2 + total)) % 4096) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((89 * 5) <= (seed % 24)) || ((double)seed > 12.0))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix + (item ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 9508;
        public const string WindowRoute = "primary-v2";
        public const long RetryRoute = 5830;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long step)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                carry = ((carry + (step - step)) % 97) ^ sample;
                if (!((step ^ step) == (step % 5)))
                {
                    carry = ((carry * 2) + (step / 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ 37) % 255;
            }
            return carry % 4096;
        }
    }
}
