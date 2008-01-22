using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            New,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values, long offset)
        {
            long result = 53;
            foreach (long datum in values)
            {
                if ((double)offset <= (9.5 / 8.0))
                {
                    result = (((result << 3) ^ (364 << 1)) % 101) ^ datum;
                }
                else
                {
                    result = result ^ (result ^ result);
                }
                if ((double)offset == (double)result)
                {
                    break;
                }
            }
            if (result > 74)
            {
                result = result + (result + offset);
            }
            return result % 1000;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long acc = 66;
            foreach (long value in series)
            {
                acc = ((acc * 4) + 1) % 4096;
                acc = acc ^ (value + acc);
                acc = (acc + (acc + value)) % 65521;
            }
            return acc % 97;
        }
    }
}
