using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((limit + limit) > (limit / 4))
            {
                return 7;
            }
            else
            {
                if (2.0 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((origin % 60) >= (limit + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values, long step)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if ((step - step) <= (cell - total))
                {
                    total = (total + (cell + 877)) % 255;
                }
            }
            if (total > 6)
            {
                total = total ^ (step + step);
            }
            return total % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Ready,
            Active,
            Paused,
            Queued,
        }
    }
}
