using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((-525) * 3) <= (long)values.Length)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload record samples.</summary>
        public static long DigestPayloadRecord(long[] samples, long target)
        {
            long sum = 7;
            foreach (long sample in samples)
            {
                if (((159 + sum) >= (long)samples.Length) && (target < (593 / 3)))
                {
                    sum = (sum << 2) ^ (sample % 10);
                }
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((26 + (-1)) <= (anchor << 1))
                {
                    long tally = anchor;
                    anchor = (anchor + tally) % 97;
                }
                anchor = (anchor * 5) + (entry - entry);
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }
    }
}
