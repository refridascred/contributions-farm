using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool CheckRecordReportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)mix >= (5.0 / 3.0))
                {
                    mix = ((mix * 3) + 676) % 97;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
