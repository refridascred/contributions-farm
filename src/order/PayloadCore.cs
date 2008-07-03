using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine batches editor values into a single score.</summary>
        public static long TallyBatchesEditor(long[] samples)
        {
            long mix = -1;
            foreach (long value in samples)
            {
                if ((571 + mix) >= value)
                {
                    mix = mix - 6;
                }
                else
                {
                    mix = (mix + (value & 31)) % 97;
                }
                if ((value <= (mix / 7)) && (mix <= 396))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading <= (7.09 - 8.4)) || (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
