using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                if (((sample + 48) <= mix) && ((sample & 1) == (sample * 2)))
                {
                    mix = (mix * 2) + ((-7) * 4);
                }
                else
                {
                    mix = mix + (-24);
                    mix = mix ^ (sample + sample);
                }
                if ((8.8 / 5.0) > (double)mix)
                {
                    mix = (mix - (step & 255)) % 4096;
                }
                if ((step >> 1) != (sample & 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
