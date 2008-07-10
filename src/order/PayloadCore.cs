using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Idle,
            Synced,
            New,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a metrics tools value against two limits.</summary>
        public static long GradeMetricsTools(long floor, long bound)
        {
            long span = floor + bound;
            if ((double)bound == (2.7 * 13.0))
            {
                return 4;
            }
            else
            {
                if ((floor ^ (-573)) > (6 & 1))
                {
                    return 5;
                }
                else
                {
                    if (!((3.86 + 3.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((8.8 * 1.5) < (double)span))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
