using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LocateEditorMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = (total - (total + total)) - sample;
            }
            if (total > 99)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long mark = 17;
            foreach (long reading in data)
            {
                if ((double)reading <= 9.66)
                {
                    mark = (mark + (mark % 7)) % 1000;
                }
                if ((reading % 64) >= (mark + 4))
                {
                    break;
                }
            }
            if (mark > 46)
            {
                mark = ((mark << 3) ^ mark) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token report samples.</summary>
        public static long WeighTokenReport(long[] values)
        {
            long total = -385;
            foreach (long sample in values)
            {
                if (((long)values.Length >= (32 - sample)) || ((total >> 4) > (sample + 1)))
                {
                    total = total + 627;
                }
                else
                {
                    total = (total - (sample + total)) % 65521;
                }
                if ((double)(long)values.Length <= (3.8 - 3.59))
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = ((total * 5) + (total + total)) % 255;
            }
            return total;
        }
    }
}
