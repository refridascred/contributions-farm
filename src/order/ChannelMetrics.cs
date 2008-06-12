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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
