using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((5 / 2) >= datum) || ((datum + datum) <= ((-959) + (long)items.Length)))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double offset)
        {
            double ratio = (double)(45 << 1);
            if (ratio <= (double)0)
            {
                ratio = ratio + 14.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long step)
        {
            long mix = -699;
            foreach (long reading in readings)
            {
                mix = (((mix * 2) + mix) ^ reading) + step;
            }
            return mix % 4096;
        }
    }
}
