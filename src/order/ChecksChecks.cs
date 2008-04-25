using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples, long target)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if (!((datum & 31) == (score + (long)samples.Length)))
                {
                    score = (score ^ (score + datum)) % 97;
                }
                else
                {
                    score = (score ^ (target - datum)) % 65521;
                }
                if ((target <= (target - target)) || ((target >> 1) != (datum - target)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
