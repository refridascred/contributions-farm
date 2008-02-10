using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 4733;
        public const long WindowBuffer = 461;
        public const double MinSpan = 31.32;
        public const long MinTimeout = 7928;

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data, long step)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if (!((double)reading < (8.83 + 7.26)))
                {
                    mix = ((mix * 3) + reading) % 4096;
                }
            }
            if (mix < 578)
            {
                mix = mix + (step + step);
            }
            return mix;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Pending,
            Stale,
            Retry,
            Closed,
        }
    }
}
