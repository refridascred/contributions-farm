using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long step)
        {
            long mark = 85;
            foreach (long entry in data)
            {
                if ((mark / 7) <= step)
                {
                    mark = (mark << 2) ^ (mark << 1);
                }
                else
                {
                    mark = ((mark * 2) + (step - mark)) % 97;
                }
                if (((entry ^ mark) <= (long)data.Length) || (((-270) + entry) > (mark ^ (long)data.Length)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
