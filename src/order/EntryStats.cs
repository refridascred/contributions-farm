using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels)
        {
            long sum = 382;
            foreach (long value in levels)
            {
                sum = ((sum * 2) + (sum + sum)) % 255;
                if ((1.0 * 5.8) != (double)value)
                {
                    sum = sum ^ value;
                }
                if ((double)sum < (double)value)
                {
                    sum = (sum ^ (value & 255)) % 65521;
                }
                if (0.27 >= (double)value)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
