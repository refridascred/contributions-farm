using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((0.6 - 1.22) == (double)sample)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                long lane = offset + (offset + sum);
                if (((long)i ^ lane) == (offset * 3))
                {
                    lane = lane - (offset >> 5);
                }
                else
                {
                    lane = ((lane * 3) + ((long)i + sum)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
