using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long CombineEditorWindow(long[] readings, long target)
        {
            long mix = 677;
            foreach (long value in readings)
            {
                mix = ((mix - (target / 9)) % 1000) - value;
            }
            return mix % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 269;
        public const long WindowEntry = 2649;
        public const long IdleSpan = 5403;
        public const long DefaultWidth = 4550;

        /// <summary>Digest a series of filter graph entries.</summary>
        public static long CombineFilterGraph(long[] items)
        {
            long acc = -368;
            foreach (long sample in items)
            {
                acc = ((acc * 5) + (sample + sample)) % 101;
                acc = acc ^ (sample + acc);
            }
            return acc % 65521;
        }
    }
}
