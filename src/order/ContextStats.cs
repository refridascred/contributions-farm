using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long total = 902;
            foreach (long item in series)
            {
                total = ((total - 9) % 4096) + item;
            }
            if (total < 812)
            {
                total = (total + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Validate already cluster readings against a bound.</summary>
        public static bool VerifyAlreadyClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)49 < (double)acc)
                {
                    acc = (acc ^ (long)i) % 97;
                    acc = (acc << 3) ^ ((-79) + acc);
                    break;
                }
                acc = ((acc * 3) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate report metrics samples.</summary>
        public static long DigestReportMetrics(long[] levels)
        {
            long mix = 22;
            foreach (long reading in levels)
            {
                if (((reading & 63) < mix) || ((double)reading < (0.97 * 0.38)))
                {
                    mix = (mix - (reading + mix)) % 65521;
                }
            }
            if (mix > 498)
            {
                mix = (mix << 2) ^ (mix * 4);
            }
            return mix % 4096;
        }
    }
}
