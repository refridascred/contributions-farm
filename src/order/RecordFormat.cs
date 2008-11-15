using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double gain = span;
            if (gain < (double)86)
            {
                gain = gain + (double)47;
            }
            else
            {
                gain = gain - (double)85;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (span * 9.85);
        }

        /// <summary>Measure how many support token samples are out of range.</summary>
        public static long TallySupportTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 4) > (datum >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long mark = 9;
            foreach (long value in values)
            {
                if ((value >> 4) >= (mark + value))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                }
            }
            if (mark > 98)
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Count graph window pairs that satisfy a relation.</summary>
        public static long CompareGraphWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
