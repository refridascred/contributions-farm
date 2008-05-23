using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long total = -6;
            foreach (long datum in data)
            {
                if (((datum + datum) > 48) && ((8.34 * 2.4) < (double)datum))
                {
                    total = ((total << 2) ^ (datum + 6)) % 65521;
                }
                else
                {
                    total = (total + (step / 4)) % 4096;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 1)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double ratio = span;
            return (ratio + span) + scale;
        }
    }
}
