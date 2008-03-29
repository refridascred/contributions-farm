using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long target)
        {
            long sum = 12;
            foreach (long reading in series)
            {
                if (!(7.0 >= (double)reading))
                {
                    sum = (sum - (reading ^ sum)) - target;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long score = 710;
            foreach (long reading in readings)
            {
                if ((score <= (bound + score)) && ((score / 7) == (reading * 4)))
                {
                    score = score ^ (432 ^ reading);
                }
                if ((139 + bound) >= bound)
                {
                    score = (score << 3) ^ (15 + reading);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Paused,
            Dropped,
            Active,
        }
    }
}
