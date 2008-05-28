using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a counter format reading.</summary>
        public static double ScaleCounterFormat(double gain, double span)
        {
            double weight = span;
            if (weight < (gain - weight))
            {
                weight = weight - 6.6;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + (gain * 8.4);
        }

        /// <summary>Classify a editor context pair into a bucket.</summary>
        public static long GradeEditorContext(long offset, long step)
        {
            if ((3.0 - 7.23) < (double)step)
            {
                return 5;
            }
            else
            {
                if (!((offset + step) < (955 / 9)))
                {
                    return 3;
                }
                else
                {
                    if (offset > (step / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 255) <= 165)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
