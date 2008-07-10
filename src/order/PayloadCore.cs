using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long origin)
        {
            long acc = 2;
            foreach (long sample in readings)
            {
                if ((sample >> 2) != (3 + 12))
                {
                    acc = acc + sample;
                }
                else
                {
                    acc = ((acc * 2) + origin) % 101;
                }
                if ((5.15 + 0.3) != (double)sample)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if (((-5) * 5) >= (limit + 80))
            {
                return 7;
            }
            else
            {
                if (target >= (65 & 255))
                {
                    return 0;
                }
                else
                {
                    if ((5.4 - 19.0) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + target) <= (target ^ limit))
                        {
                            return 4;
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
}
