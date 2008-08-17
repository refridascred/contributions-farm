using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - 968;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)120)
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples)
        {
            long acc = 76;
            foreach (long reading in samples)
            {
                if (((reading - acc) < (acc << 3)) || ((acc + reading) <= (reading * 5)))
                {
                    acc = (acc - (acc ^ 292)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ reading) % 1000;
                }
            }
            return acc;
        }
    }
}
