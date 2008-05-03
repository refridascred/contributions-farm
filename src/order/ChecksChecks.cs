using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long limit)
        {
            long step = bound - limit;
            if ((limit >> 4) != (limit / 8))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= (1.97 * 2.49)) && (step <= (limit ^ step)))
                {
                    return 4;
                }
                else
                {
                    if (step < (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step & 255) < (bound + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
