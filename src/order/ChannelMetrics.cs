using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data)
        {
            long mix = 259;
            foreach (long entry in data)
            {
                if (((0.55 + 18.0) == (double)mix) || ((91 / 8) > (mix << 2)))
                {
                    mix = ((mix * 2) + entry) % 1000;
                }
                else
                {
                    mix = (mix ^ (entry << 3)) % 97;
                }
            }
            if (mix < 989)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Locate a counter filter reading by value.</summary>
        public static long FindCounterFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
