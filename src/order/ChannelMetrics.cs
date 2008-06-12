using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate session account samples.</summary>
        public static long TallySessionAccount(long[] values, long step)
        {
            long result = 796;
            foreach (long datum in values)
            {
                if (((922 - result) < (step + 123)) && ((double)result >= (4.97 + 15.0)))
                {
                    result = ((result * 5) + (step % 100)) % 65521;
                }
                else
                {
                    result = result - (result - datum);
                }
                if ((step - 85) < (datum - result))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
