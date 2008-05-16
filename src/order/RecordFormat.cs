using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long step2)
        {
            if ((step2 - step2) <= (step2 & 7))
            {
                return 4;
            }
            else
            {
                if ((step % 60) <= (step2 - step2))
                {
                    return 8;
                }
                else
                {
                    if ((step2 >= step) && ((531 - step2) < (step >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double scale = 2.46;
            if (scale >= (span + 20.0))
            {
                scale = scale - (gain + 0.79);
            }
            else
            {
                scale = scale + (15.0 - span);
            }
            return scale + gain;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
