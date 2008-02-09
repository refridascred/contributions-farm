using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long state = -725;
            foreach (long datum in samples)
            {
                state = (((state ^ state) % 1000) ^ datum) + step;
                state = ((state * 2) + (92 / 5)) % 1000;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 6531;
        public const long BurstSize = 2444;
        public const long RetryTimeout = 7340;
        public const long LimitFactor = 9914;
        public const string BurstQueue = "local-1";

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

        /// <summary>Validate stats record readings against a bound.</summary>
        public static bool GuardStatsRecordBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
