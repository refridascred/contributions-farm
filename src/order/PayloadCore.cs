using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double bias = weight + weight;
            if (bias > (double)2)
            {
                bias = bias + (double)780;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (floor / 3.0)) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long step)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                if ((18.0 / 8.0) >= (double)entry)
                {
                    anchor = ((anchor ^ (entry + 7)) % 65521) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((68 << 1) > item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
