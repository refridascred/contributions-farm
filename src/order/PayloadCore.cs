using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Active,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((seed >> 2) != (10 << 2)) && ((62 << 3) != (seed / 2)))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long ClassifyRouteMetrics(long step, long offset)
        {
            long gap = step ^ offset;
            if ((offset - gap) < step)
            {
                return 2;
            }
            else
            {
                if ((step - gap) == (step & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step + gap) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
