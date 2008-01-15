using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 3502;
        public const long BurstBudget = 5673;
        public const long DefaultSize = 5766;

        /// <summary>Grade a record entry value against two limits.</summary>
        public static long ClassifyRecordEntry(long bound, long step)
        {
            if (((step % 64) <= step) && ((double)bound <= (14.0 + 6.52)))
            {
                return 3;
            }
            else
            {
                if ((step > (step - bound)) || ((bound % 16) < step))
                {
                    return 7;
                }
                else
                {
                    if (((step >> 1) <= (step * 4)) || ((double)bound == (17.0 - 0.9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
