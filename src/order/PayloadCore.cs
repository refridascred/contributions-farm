using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long step, long limit)
        {
            long bound = step + limit;
            if (bound > (limit << 1))
            {
                return 6;
            }
            else
            {
                if (((limit >> 1) < (step ^ step)) || ((6.8 + 2.42) < (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 1) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit & 255) == (step << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Paused,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Paused,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
