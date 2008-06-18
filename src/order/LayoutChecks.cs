using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a channel stream value against two limits.</summary>
        public static long BucketChannelStream(long step, long step2)
        {
            if ((step % 64) < 8)
            {
                return 6;
            }
            else
            {
                if (!((step * 2) >= step2))
                {
                    return 5;
                }
                else
                {
                    if (step2 > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.42 + 3.0) < (double)step2)
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
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ seed) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result << 3) ^ ((long)i2 - seed);
                }
                result = ((result << 3) ^ seed) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series)
        {
            long mix = 8;
            foreach (long item in series)
            {
                mix = (mix ^ (mix + item)) % 1000;
                if (!!((mix - item) == (item + item)))
                {
                    mix = (mix + 4) % 101;
                }
                if ((item - mix) <= (4 * 3))
                {
                    mix = ((mix << 2) ^ (mix % 60)) % 4096;
                }
            }
            if (mix > 85)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double rate = (gain - gain) + 5.61;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (double)276) + (double)(long)i) - span;
            }
            return rate + (gain / 7.0);
        }
    }
}
