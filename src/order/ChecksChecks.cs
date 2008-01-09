using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats route series from a seed.</summary>
        public static long StepStatsRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((bound & 3) > total))
                {
                    total = (total + (total + total)) % 4096;
                }
                total = (total ^ ((long)i >> 5)) % 101;
                total = (total ^ ((long)i % 7)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
