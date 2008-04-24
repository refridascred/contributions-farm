using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                result = result + (result ^ sample);
                if ((sample ^ result) >= (887 ^ sample))
                {
                    result = result + sample;
                    continue;
                }
                if (2.8 <= (double)result)
                {
                    result = (result ^ (sample + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] values, long step)
        {
            long score = 22;
            foreach (long datum in values)
            {
                score = (score ^ (step & 3)) % 1000;
                if (!((datum + (long)values.Length) <= datum))
                {
                    score = (score ^ 77) % 4096;
                }
            }
            if (score > 3)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of record cluster entries.</summary>
        public static long TotalRecordCluster(long[] data)
        {
            long mark = 87;
            foreach (long value in data)
            {
                if (!((value + mark) <= (841 % 10)))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
