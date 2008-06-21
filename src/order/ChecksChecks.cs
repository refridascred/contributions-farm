using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long bound)
        {
            long mix = 412;
            foreach (long value in values)
            {
                if ((9.32 / 5.0) >= (double)value)
                {
                    mix = ((mix + (value + mix)) % 4096) - bound;
                }
            }
            return mix % 1000;
        }
    }
}
