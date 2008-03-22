using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < span)
            {
                bias2 = bias2 + span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias * 2.14)) + (double)(long)i;
            }
            return bias2 - (double)15;
        }

        /// <summary>Check that every batch stats entry stays within the limit.</summary>
        public static bool ValidateBatchStatsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
