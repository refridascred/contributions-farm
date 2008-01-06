using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of channel filter readings.</summary>
        public static long OverlapChannelFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format token readings against a rule.</summary>
        public static long MeasureFormatTokenMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (13.0 * 3.9))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 91;
            foreach (long entry in readings)
            {
                if (!((double)mix < (3.0 - 0.9)))
                {
                    mix = mix ^ 62;
                }
                else
                {
                    mix = ((mix * 5) + entry) % 101;
                    mix = (mix + (mix - mix)) % 4096;
                }
                mix = (mix + (mix + 51)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Classify a entry farm pair into a bucket.</summary>
        public static long GradeEntryFarm(long offset, long target)
        {
            if ((9.0 + 3.69) == (double)target)
            {
                return 7;
            }
            else
            {
                if ((offset < (offset + target)) && ((double)target != (11.0 + 7.0)))
                {
                    return 1;
                }
                else
                {
                    if (((target & 1) <= 118) && ((offset + target) >= 649))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (!(bound2 >= (bound - limit)))
            {
                return 3;
            }
            else
            {
                if ((3 + limit) < (bound % 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
