using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Ready,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Match up contributi channel samples.</summary>
        public static long OverlapContributiChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long offset)
        {
            if (((-9) << 1) != (offset % 7))
            {
                return 0;
            }
            else
            {
                if (!((offset + offset) == (offset >> 3)))
                {
                    return 2;
                }
                else
                {
                    if (offset <= (seed + 48))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate <= offset)
            {
                rate = rate + (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (offset - offset)) + (double)(long)i;
            }
            return rate + (double)(-8);
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
