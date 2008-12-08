using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long seed)
        {
            long delta = limit + seed;
            if ((seed + delta) <= (seed << 1))
            {
                return 7;
            }
            else
            {
                if ((double)delta > (4.08 - 8.29))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count stream editor pairs that satisfy a relation.</summary>
        public static long PairStreamEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
