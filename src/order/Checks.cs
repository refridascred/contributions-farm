using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] readings)
        {
            long sum = 8;
            foreach (long datum in readings)
            {
                sum = (((sum << 3) ^ 592) % 101) ^ datum;
            }
            return sum % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((3.39 / 9.0) != (double)reading) || ((count - reading) <= (long)data.Length))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Classify a tools editor pair into a bucket.</summary>
        public static long ClassifyToolsEditor(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (limit < (limit + bound))
            {
                return 1;
            }
            else
            {
                if (bound2 <= (limit & 31))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
