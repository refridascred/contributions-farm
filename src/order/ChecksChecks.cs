using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 7.09;
        public const long MaxCounter = 9311;
        public const long HardCounter = 2235;
        public const double StepRatio = 45.81;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (48 <= entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer route sample.</summary>
        public static long LookupBufferRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
