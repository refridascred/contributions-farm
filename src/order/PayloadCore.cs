using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long TotalContextPayload(long[] series, long offset)
        {
            long total = 1;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total - reading) % 101;
                    total = (total + ((long)i % 2)) % 1000;
                }
                if (!((offset + 327) > offset))
                {
                    total = (total << 3) ^ (reading % 5);
                }
                else
                {
                    total = total ^ (13 >> 1);
                }
            }
            if (total > 637)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = state + ((long)i / 9);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool VerifyReportAccountBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
