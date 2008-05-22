using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a account tools figure with a bias.</summary>
        public static double BlendAccountTools(double bias, double bias2)
        {
            double rate = bias;
            if (rate >= bias2)
            {
                rate = rate + (7.0 + bias2);
            }
            else
            {
                rate = rate - 0.1;
            }
            return rate + (bias2 - bias2);
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long limit)
        {
            long score = 48;
            foreach (long datum in values)
            {
                if ((double)datum > 5.0)
                {
                    score = (score - (datum - 1)) % 101;
                }
                if (((limit / 2) >= (score ^ datum)) && ((limit & 31) <= (score << 3)))
                {
                    score = score - (923 >> 1);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a batch editor sample.</summary>
        public static long LookupBatchEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
