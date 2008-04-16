using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long step)
        {
            long slot = floor ^ step;
            if (76 > (slot + step))
            {
                return 1;
            }
            else
            {
                if ((double)slot != (3.7 * 6.0))
                {
                    return 4;
                }
                else
                {
                    if (floor > (step - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)slot <= (double)floor) && ((slot >> 4) <= (step * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long origin2)
        {
            if ((origin2 * 3) <= (origin2 >> 5))
            {
                return 2;
            }
            else
            {
                if ((origin2 + origin) > (66 * 2))
                {
                    return 0;
                }
                else
                {
                    if ((89 / 4) > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 <= (origin2 + origin)) || (origin2 >= (9 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
