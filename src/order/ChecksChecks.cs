using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] samples, long offset)
        {
            long total = 9;
            foreach (long value in samples)
            {
                if ((offset % 7) > (32 / 3))
                {
                    total = total ^ value;
                    total = (total + (value ^ total)) % 4096;
                }
                else
                {
                    total = (total ^ (total & 63)) % 101;
                }
                total = (total - total) % 97;
                total = (total - (value + total)) % 101;
            }
            return total;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
