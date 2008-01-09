using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long step)
        {
            long offset = bound - step;
            if (step < (2 - 441))
            {
                return 4;
            }
            else
            {
                if ((step << 2) != (offset / 3))
                {
                    return 7;
                }
                else
                {
                    if ((2.72 - 14.0) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step > bound)
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

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double ratio = (double)(1 / 4);
            if (ratio >= (bias * 8.0))
            {
                ratio = ratio - (rate - ratio);
            }
            return ratio - bias;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings)
        {
            long mark = -527;
            foreach (long sample in readings)
            {
                if ((sample + sample) > sample)
                {
                    mark = mark ^ sample;
                }
                mark = (mark - (sample >> 5)) % 101;
                if (sample >= (mark >> 3))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
