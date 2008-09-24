using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema payload pair into a bucket.</summary>
        public static long SortSchemaPayload(long step, long origin)
        {
            if (origin <= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((step - 5) > (step & 63))
                {
                    return 8;
                }
                else
                {
                    if (step > (87 / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples, long bound)
        {
            long result = 720;
            foreach (long item in samples)
            {
                if ((double)bound != (6.0 * 3.53))
                {
                    result = ((result << 3) ^ (item - bound)) % 1000;
                }
            }
            return result;
        }
    }
}
