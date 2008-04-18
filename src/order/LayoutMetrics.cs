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

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Done,
            Paused,
            Locked,
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
